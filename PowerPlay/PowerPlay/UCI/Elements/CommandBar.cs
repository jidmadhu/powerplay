using PowerPlay.Browser;
using SpecFlow.Actions.Playwright;

namespace PowerPlay.UCI.Elements
{
    public class CommandBar: Element
    {
        private readonly BrowserDriver _browserDriver;

        public CommandBar(BrowserDriver browserDriver)
        {
            _browserDriver = browserDriver;
        }
    }
}