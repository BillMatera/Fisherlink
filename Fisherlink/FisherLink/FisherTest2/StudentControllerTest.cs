using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using FisherLink.Controllers;
using FisherLink.Data;
using Microsoft.EntityFrameworkCore;
using Xunit.Abstractions;

namespace TestingControllersSample.Tests.UnitTests
{
    // Testing the View name returned by a Controller.  Had to update StudentsController Create method to specify: return View("Create");
    // If "Create" is not specified then nothing is returned b/c controller-method is not called through the MVC pipeline.
    public class ControllerNameTest
    {
        //The following will provide for displaying output. click output link in test explorer after run.
        private readonly ITestOutputHelper output;
        public ControllerNameTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public async Task TestControllerAsync()
        {

            //http://stackoverflow.com/questions/39481353/how-do-i-moq-the-applicationdbcontext-in-net-core
            // Need to setup the ApplicationDbContext, since this is done in Startup.cs which is not part of test project.
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseInMemoryDatabase();  //had to add package Microsoft.EntityFrameworkCore.InMemory
            var _dbContext = new ApplicationDbContext(optionsBuilder.Options);
            var controller = new StudentsController(_dbContext);

            // Act
            var result = controller.Create() as ViewResult;

            //output.WriteLine("view name: " + result.ViewName );  //debug output.

            //Assert
            Assert.Equal("Create", result.ViewName);
        }

    }
}