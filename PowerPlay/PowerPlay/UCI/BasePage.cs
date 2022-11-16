using System.Threading.Tasks;
using Microsoft.Playwright;
using SpecFlow.Actions.Playwright;

namespace PowerPlay.UCI
{
    public class BasePage
    {
        public readonly Task<IPage> Page;

        public BasePage(BrowserDriver browserDriver) => Page = CreatePageAsync(browserDriver.Current); 
        
        private async Task<IPage> CreatePageAsync(Task<IBrowser> browser) =>  await (await browser).NewPageAsync();
        
    }
}