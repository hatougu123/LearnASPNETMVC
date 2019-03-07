using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Controllers;
using System.Web.Mvc;

namespace WebApplication1.Tests.Controllers
{
    [TestClass]
    public class Calculator
    {
        [TestMethod]
        public void TestIndex()
        {
            // Arrange
            var controller= new CalculatorController();

            // Act
            var result = controller.Index();

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestShowAuthor()
    }
}
