using OpenQA.Selenium;

namespace yomail_project.src.code.control
{
    public class TextBox : Control
    {
        public TextBox(By locator) : base(locator)
        {
        }

        public void SetText(String value) 
        {
            FindControl();
            control.Clear();
            control.SendKeys(value);
        }

    }
}
