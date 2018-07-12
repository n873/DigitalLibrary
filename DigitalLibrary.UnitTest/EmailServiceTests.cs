using DigitalLibrary.Web.Services;
using Xunit;

namespace DigitalLibrary.UnitTest
{
    public class EmailServiceTests
    {
        [Fact]
        public void SendEmail_NoConditions_Success()
        {
            var service = new EmailService();
            service.SendEmail();

            Assert.True(service.MailSent);
        }
    }
}
