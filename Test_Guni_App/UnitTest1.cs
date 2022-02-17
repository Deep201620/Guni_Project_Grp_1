using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuniApp_Proj_1.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MSTestProjectForController
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task CheckIndexReturnsView()
        {
            // 1. Arrange
            // create an IDisposable dbContext object.
            using var dbContext = DbContextMocker.GetApplicationDbContext("TestMethod1");
            var controller = new DepartmentsController(dbContext);

            // 2. Act
            var actionResult = await controller.Index();

            // 3. Assert 
            Assert.IsInstanceOfType(actionResult, typeof(ViewResult));
        }

        [TestMethod]
        public async Task CheckIndexReturnsData()
        {
            // 1. Arrange
            // create an IDisposable dbContext object.
            using var dbContext = DbContextMocker.GetApplicationDbContext("TestMethod1");
            var controller = new DepartmentsController(dbContext);

            // 2. Act
            var actionResult = await controller.Index();

            // 3. Assert (a) if the result of the action is a View
            Assert.IsInstanceOfType(actionResult, typeof(ViewResult));

            var result = actionResult as ViewResult;
            if (!string.IsNullOrEmpty(result.ViewName))
            {
                Assert.AreEqual("Index", result.ViewName);
            }

        }
        }
    }
