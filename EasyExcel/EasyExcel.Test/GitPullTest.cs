using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EasyExcel.Test
{
    [TestClass]
    public class GitPullTest
    {
        [TestMethod]
        public void Should_fatch_Commit_log()
        {
            GitVersionControlpull pullobj = new GitVersionControlpull(@"E:\easyexcel test\test version.xlsx");
            var result = pullobj.GetGitlog();
            Assert.AreNotEqual(0, result.Count);
        }
    }
}
