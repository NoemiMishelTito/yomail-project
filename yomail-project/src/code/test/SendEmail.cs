using OpenQA.Selenium;
using yomail_project.src.code.control;
using yomail_project.src.code.page;

namespace yomail_project.src.code.test
{
    [TestClass]
    public class SendEmail : TestBase
    {
        Floatcpt goInbox = new Floatcpt();
        InboxRight viewEmail= new InboxRight();
        InboxLeft emailManager = new InboxLeft();

        [TestMethod]
        public void SendEmailVerifyMessage()
        {
            goInbox.SetEmail("mishtito@test.com");
            // new Url verification
            Assert.IsTrue(session.Session.Instance().GetCurrentUrl().Equals("https://yopmail.com/wm"), "The url is different from https://yopmail.com/wm");
            emailManager.OpenRedactMessage();
            viewEmail.SwithIframe();
            viewEmail.setMessage("mishtito@yopmail.com", "Auto-Test1", "I'm really excited");
            //Verify Message was send
            Assert.IsTrue(viewEmail.CheckMessage(), "The message was not sent successfully.");
            viewEmail.returnI();
            emailManager.ShowInbox();
            viewEmail.SwithIframe();
            viewEmail.MouseHover();
            Assert.IsTrue(viewEmail.CheckDeliver(), "The message has not been received");
        }
    }
}
