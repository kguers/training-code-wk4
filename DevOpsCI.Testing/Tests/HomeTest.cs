using Xunit;
using DevOpsCI.Client.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DevOpsCI.Testing.Tests
{
     public class HomeTest
     {
          private ILogger<HomeController> _logger = LoggerFactory.Create(options => options.AddConsole()).CreateLogger<HomeController>();
          [Fact]
          public void HomeController_Test()
          {
               var sut = new HomeController(_logger);
               var view = sut.Index();
          }
     }
}