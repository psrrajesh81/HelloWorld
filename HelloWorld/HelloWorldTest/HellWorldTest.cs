using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld.BL;
namespace HelloWorldTest
{
    [TestClass]
    public class HellWorldTest
    {
        [TestMethod]
        public void TestHelloWorld()
        {
            BusinessLogic _objBL = new BusinessLogic();
            Assert.AreEqual("Hello World", _objBL.DisplayHelloWorld());
        }
    }
}
