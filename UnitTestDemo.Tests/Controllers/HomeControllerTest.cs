using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using UnitTestDemo.Controllers;
using UnitTestDemo.Models;

namespace UnitTestDemo.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page..", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestIndexMethod()
        {
            // Arrange
            HomeController controller = new HomeController();
            string ViewName = "Index";
            string name = "Chandu";
            // Act
            var result =controller.Index() as ViewResult;
            var model = (Employee)result.Model;

            // Assert
            Assert.AreEqual(ViewName, result.ViewName);
            Assert.AreEqual(name,model.Name);
        }
    }
}
