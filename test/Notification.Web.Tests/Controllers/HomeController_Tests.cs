using System.Threading.Tasks;
using Notification.Models.TokenAuth;
using Notification.Web.Controllers;
using Shouldly;
using Xunit;

namespace Notification.Web.Tests.Controllers
{
    public class HomeController_Tests: NotificationWebTestBase
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