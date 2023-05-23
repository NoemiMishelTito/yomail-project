using OpenQA.Selenium;


namespace yomail_project.src.code.control
{
    public class Iframe : Control
    {
        private IWebElement iframeElement;
        public Iframe(By locator) : base(locator)
        {
        }

        public void SwitchToIframe()
        {
            iframeElement = session.Session.Instance().GetBrowser().FindElement(locator);
            iframe.SwitchTo().Frame(iframeElement);
        }

        public void SwitchToDefaultContent()
        {
            iframe.SwitchTo().DefaultContent();
        }
    }
}
