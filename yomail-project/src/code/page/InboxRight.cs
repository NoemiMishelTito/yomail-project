using OpenQA.Selenium;
using yomail_project.src.code.control;

namespace yomail_project.src.code.page
{
    public class InboxRight
    {
      
        public Iframe iframeMsg =  new Iframe(By.XPath("//iframe[@id='ifmail']"));
        public TextBox msgTo = new TextBox(By.Id("msgto"));
        public TextBox msgSubject = new TextBox(By.Id("msgsubject"));
        public TextBox msgBody = new TextBox(By.Id("msgbody"));
        public Button msgSend = new Button(By.Id("msgsend"));
        public Label msgSent = new Label(By.Id("msgpopmsg"));
        public Button deliverBtn = new Button(By.Id("icodeliverability"));

        public void SwithIframe()
        {
            iframeMsg.SwitchToIframe();
        }
        public void returnI()
        {
            iframeMsg.SwitchToDefaultContent();
        }
        public void setMessage(String email, String subject, String Text)
        {
            msgTo.SetText(email);
            msgSubject.SetText(subject);
            msgBody.SetText(Text);
            msgSend.IsControlDisplayed();
            msgSend.Click();
        }

        public void MouseHover() 
        {
            deliverBtn.mouseOver();
        }
        public bool CheckMessage()
        {
            return msgSent.IsControlDisplayed();
        }
        public bool CheckDeliver()
        {
            return deliverBtn.IsControlDisplayed();
        }
    }
}
