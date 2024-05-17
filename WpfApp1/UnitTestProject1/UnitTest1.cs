using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 0;
            int b = MyClass.Add(0, 0);
            Assert.AreEqual(a, b);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int a = 5;
            int b = MyClass.Add(2, 3);
            Assert.AreEqual(a, b);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int a = 4;
            int b = MyClass.Add(2, 2);
            Assert.AreEqual(a, b);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int a = 7;
            int b = MyClass.Add(3, 4);
            Assert.AreEqual(a, b);
        }
        [TestMethod]
        public void TestMethod5()
        {
            int a = 8;
            int b = MyClass.Add(3, 5);
            Assert.AreEqual(a, b);
        }
        [TestMethod]
        public void TestMethod6()
        {
            int a = 1;
            int b = MyClass.Add(1, 0);
            Assert.AreEqual(a, b);
        }
        [TestMethod]
        public void TestMethod7()
        {
            int a = -2;
            int b = MyClass.Add(5, -7);
            Assert.AreEqual(a, b);
        }
        [TestMethod]
        public void TestMethod8()
        {
            int a = 5;
            int b = MyClass.Add(5, 0);
            Assert.AreEqual(a, b);
        }
        [TestMethod]
        public void TestMethod9()
        {
            int a = 9;
            int b = MyClass.Add(10, -1);
            Assert.AreEqual(a, b);
        }
        [TestMethod]
        public void TestMethod10()
        {
            int a = 10;
            int b = MyClass.Add(5, 5);
            Assert.AreEqual(a, b);
        }
    }
}
