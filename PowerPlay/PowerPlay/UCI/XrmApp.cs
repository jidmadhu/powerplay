using System;
using PowerPlay.Browser;
using PowerPlay.UCI.Elements;
using SpecFlow.Actions.Playwright;

namespace PowerPlay.UCI
{
    public class XrmApp : BasePage

    {
        private readonly BrowserDriver _browserDriver;

        public XrmApp(BrowserDriver browserDriver) : base(browserDriver)
        {
            _browserDriver = browserDriver;
        }

        public T GetElement<T>(BrowserDriver browserDriver) where T : Element =>
            (T) Activator.CreateInstance(typeof(T), browserDriver);

        public CommandBar CommandBar => GetElement<CommandBar>(_browserDriver);
    }
}