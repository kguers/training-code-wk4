using Xunit;
using DevOpsCI.Client.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace DevOpsCI.Testing.Tests
{
     public class HomeTest
     {
          [Fact]
          public void HomeController_Test()
          {
               var sut = new HomeController();
               var view = sut.Index();
          }
     }
}