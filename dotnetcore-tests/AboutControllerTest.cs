using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dotnetcore_sample.Controllers;

namespace dotnetcore_tests
{
    public class AboutControllerTest
    {
        public void Index_Test_Loading()
        {
            // Arrange
            AboutController controller = new AboutController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewData["Message"]);

        }
        
    }
}