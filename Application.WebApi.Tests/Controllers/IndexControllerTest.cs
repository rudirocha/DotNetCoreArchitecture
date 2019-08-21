using Application.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace Application.WebApi.Tests
{
    public class IndexControllerTest
    {
        private IndexController controller;
        [SetUp]
        public void Setup()
        {
            this.controller = new IndexController();
        }

        [Test]
        public void TestIndexActionReturnsOkActionResult()
        {
            var result = this.controller.Index();
            Assert.IsAssignableFrom<OkObjectResult>(result);
        }
    }
}