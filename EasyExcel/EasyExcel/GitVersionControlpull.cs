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
                foreach (Commit c in repo.Commits.Take(15))
                {
                    GitlogModel logdata = new GitlogModel();
                    logdata.comment = c.Message;
                    logdata.date = c.Author.When.ToString(dateformat);
                    model.Add(logdata);
                }
            }
            return model;
        }

    }
}
