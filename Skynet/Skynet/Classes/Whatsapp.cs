namespace Skynet.Classes
{
    public class Whatsapp : Web
    {
        private List<string>? Contacts { get; set; } = new();
        private string? Message { get; set; }
        public string? ImagePath { get; set; }

        public Whatsapp(List<string> contacts, string message)
        {
            Contacts = contacts;
            Message = message;
        }

        public Whatsapp(List<string> contacts, string message, string imagePath)
        {
            Contacts = contacts;
            Message = message;
            ImagePath = imagePath;
        }

        public void SendMessage()
        {
            var web = new Web();
            foreach (var contact in Contacts)
            {                
                web.StartBrowser(TypeDriver.GoogleChorme, "C:\\Users\\roger\\AppData\\Local\\Google\\Chrome\\User Data");
                web.Navigate("https://web.whatsapp.com/");
                web.WaitForLoad();
                Thread.Sleep(TimeSpan.FromSeconds(15));
                var search = web.AssignValue(TypeElement.Xpath, "//*[@id=\"side\"]/div[1]/div/div/div[2]/div/div/p", contact, 6);
                search.element.SendKeys(OpenQA.Selenium.Keys.Enter);
                var messageGroup = web.AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div/div[1]/p", Message);
                messageGroup.element.SendKeys(OpenQA.Selenium.Keys.Enter);                
            }
            web.CloseBrowser();
        }

        public void SendMessageWithImage()
        {
            int quantityOfAds = 0;
            var currentTime = DateTime.Now.ToShortTimeString();            
            
            while (String.Compare(currentTime, "8:00 PM") < 0)
            {
                var currentTimeAux = DateTime.Now.ToShortTimeString();
                if (currentTimeAux == currentTime)
                {                    
                    var web = new Web();

                    web.StartBrowser(TypeDriver.GoogleChorme, "C:\\Users\\roger\\AppData\\Local\\Google\\Chrome\\User Data");
                    web.Navigate("https://web.whatsapp.com/");
                    web.WaitForLoad();
                    Thread.Sleep(TimeSpan.FromSeconds(7));

                    foreach (var contact in Contacts)
                    {
                        quantityOfAds++;

                        var search = web.AssignValue(TypeElement.Xpath, "//*[@id=\"side\"]/div[1]/div/div/div[2]/div/div/p", contact, 6);
                        search.element.SendKeys(OpenQA.Selenium.Keys.Enter);
                        web.Click(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[1]/div[2]/div/div/div/span");
                        web.AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[1]/div[2]/div/span/div/ul/div/div[1]/li/div/input", ImagePath);
                        var message = web.AssignValue(TypeElement.Xpath, "//*[@id=\"app\"]/div/div/div[3]/div[2]/span/div/span/div/div/div[2]/div/div[1]/div[3]/div/div/div[2]/div[1]/div[1]/p", Message, 6);
                        message.element.SendKeys(OpenQA.Selenium.Keys.Enter);
                    }
                    if (quantityOfAds > 0)
                    {
                        currentTime = DateTime.Now.AddHours(1).ToShortTimeString();
                        quantityOfAds = 0;
                    }
                }     
            };            
        }
    }
}
