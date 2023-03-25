using System.Threading.Tasks;
using FanuunSolution.Models.TokenAuth;
using FanuunSolution.Web.Controllers;
using Shouldly;
using Xunit;

namespace FanuunSolution.Web.Tests.Controllers
{
    public class HomeController_Tests: FanuunSolutionWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}