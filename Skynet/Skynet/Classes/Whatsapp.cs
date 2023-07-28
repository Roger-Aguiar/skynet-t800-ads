namespace Skynet.Classes
{
    public class Whatsapp : Web
    {
        public List<string>? Contacts { get; set; } = new();
        public string? Message { get; set; }

        public void SendMessage()
        {
            foreach (var contact in Contacts)
            {
                var web = new Web();
                web.StartBrowser(TypeDriver.GoogleChorme, "C:\\Users\\roger\\AppData\\Local\\Google\\Chrome\\User Data");
                web.Navigate("https://web.whatsapp.com/");
                web.WaitForLoad();
                Thread.Sleep(TimeSpan.FromSeconds(15));
                var search = web.AssignValue(TypeElement.Xpath, "//*[@id=\"side\"]/div[1]/div/div/div[2]/div/div/p", contact, 6);
                search.element.SendKeys(OpenQA.Selenium.Keys.Enter);
                var messageGroup = web.AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div/div[1]/p", Message);
                messageGroup.element.SendKeys(OpenQA.Selenium.Keys.Enter);
                web.CloseBrowser();
            }            
        }
    }
}
