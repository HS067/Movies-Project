using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Movies_Project;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        //defining an object with in the class Database from MovieStore
        DatabaseManager Obj_Test = new DatabaseManager();
        [TestMethod]
        public void TestDBConection()
        {
            // Variable of actual and expected connection String 
            var ActualDBCon = Obj_Test.str;
            var ExpexctedDBCon = "Data Source=DESKTOP-J8NDLG6\\SQLEXPRESS01;Initial Catalog=mydata;Integrated Security=True";
            //Assert - checking the output is which expected
            Assert.AreEqual(ExpexctedDBCon, ActualDBCon);
        }
    }
}
