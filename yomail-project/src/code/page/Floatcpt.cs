using OpenQA.Selenium;
using yomail_project.src.code.control;

namespace yomail_project.src.code.page
{
    public class Floatcpt
    {
        public TextBox emailTxtBox = new TextBox(By.Id("login"));
        public Button sendBtn = new Button(By.Id("refreshbut"));

        public void SetEmail(String email)
        {
            emailTxtBox.SetText(email);
            sendBtn.Click();
        }
    }
}
