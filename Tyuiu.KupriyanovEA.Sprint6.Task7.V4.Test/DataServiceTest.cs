using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.KupriyanovEA.Sprint6.Task7.V4.Lib;

namespace Tyuiu.KupriyanovEA.Sprint6.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\evgeniy\source\repos\Tyuiu.KupriyanovEA.Sprint6\Tyuiu.KupriyanovEA.Sprint6.Task7.V4\bin\Debug\InPutFileTask7V4.csv";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
