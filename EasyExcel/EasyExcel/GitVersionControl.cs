using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibGit2Sharp;

namespace EasyExcel
{
    //https://github.com/libgit2/libgit2sharp/wiki/LibGit2Sharp-Hitchhiker's-Guide-to-Git
    public class GitVersionControl
    {
        private string _filepath;
        private string _message;
        private string dirpath;
        public GitVersionControl(string filepath, string message)
        {
            _filepath = filepath;
            _message = message;
            dirpath = Path.GetDirectoryName(_filepath);
        }
        public void commmit()
        {
            if(checkForExistingGitVersion())
            {
                StagfileAndCommit();
            }
            else
            {
                Repository.Init(dirpath);
                StagfileAndCommit();
            }
        }

        private void StagfileAndCommit()
        {
            using (var repo = new Repository(dirpath))
            {
                repo.Index.Add(_filepath);
                Signature author = new Signature("EasyExcel", "NA", DateTime.Now);
                Signature committer = author;
                Commit commit = repo.Commit(_message, committer, author);
            }
        }

        bool checkForExistingGitVersion()
        {
            return Repository.IsValid(dirpath);
        }
    }
}
