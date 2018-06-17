using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EasyExcel.Test
{
    [TestClass]
    public class GetVersionFilefromGitTest
    {
        [TestMethod]
        public void TestFile()
        {
            GitVersionControlpull pullobj = new GitVersionControlpull(@"E:\easyexcel test\test version.xlsx");
            var filepath=pullobj.GetFile("9908913ae53e5764e92e7eb1e590356023850ee0");
            Assert.AreNotEqual(null, filepath);
        }
    }
}
