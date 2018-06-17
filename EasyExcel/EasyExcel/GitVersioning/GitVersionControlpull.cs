using EasyExcel.Model;
using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExcel
{
    public class GitVersionControlpull
    {
        private string _filepath;
        private string _dirpath;
        public GitVersionControlpull(string filepath)
        {
            _filepath = Path.GetFileName(filepath);
            _dirpath = Path.GetDirectoryName(filepath);
        }

        public List<GitlogModel> GetGitlog()
        {
            List<GitlogModel> model = new List<GitlogModel>();
            var dateformat = "dd-MM-yyyy HH:mm";
            using (var repo = new Repository(@_dirpath))
            {
                foreach (Commit c in repo.Commits)
                {
                    
                    GitlogModel logdata = new GitlogModel();
                    logdata.Comment = c.Message;
                    logdata.Date = c.Author.When.ToString(dateformat);
                    logdata.sha = c.Sha;
                    model.Add(logdata);
                }
            }
            return model;
        }

        public string GetFile(string sha)
        {
            string temppath = Path.GetTempPath();
            string tempdirname = DateTime.Now.ToString("ddMMyyyyHHmmss");
            Directory.CreateDirectory(temppath + tempdirname);
            string veliddirpathgit = temppath + tempdirname + @"\";
            Repository.Clone(_dirpath, veliddirpathgit);

            if (Repository.IsValid(Path.GetDirectoryName(veliddirpathgit)))
            {
                using (var repo = new Repository(veliddirpathgit))
                {
                    Commit previousCommit = repo.Head.Commits.Where(x=>x.Sha.Equals(sha)).FirstOrDefault();
                    repo.Reset(ResetMode.Hard, previousCommit);

                }

            }


            return veliddirpathgit+ @"\"+_filepath;
        }

       

    }
}
