using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TaskList taskList = new TaskList("name");

            Assert.AreEqual("name", taskList.GetName());
        }

        [TestMethod]
        public void TestMethod2()
        {
            TaskList taskList = new TaskList("name");
            Task task = new Task();

            taskList.AddTask(task);

            taskList.Remove(task);

            Assert.AreEqual(0, taskList.GetTasks().Count);
        }

        [TestMethod]
        public void TestMethod3()
        {
            TaskList taskList = new TaskList("name");
            Task task = new Task();

            taskList.AddTask(task);


            Assert.AreEqual(1, taskList.GetTasks().Count);
        }
    }
}
