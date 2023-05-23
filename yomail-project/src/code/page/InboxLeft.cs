using OpenQA.Selenium;
using yomail_project.src.code.control;

namespace yomail_project.src.code.page
{
    public class InboxLeft
    {
        public Button newMail = new Button(By.Id("newmail"));
        public Iframe iframeMsg = new Iframe(By.XPath("//iframe[@id='ifinbox']"));
        public Button refresBtn = new Button(By.Id("refresh"));

        public void OpenRedactMessage()
        {
            newMail.Click();
        }
        public void ShowInbox()
        {
            Thread.Sleep(2000);
            refresBtn.Click();
        }
    }
}
