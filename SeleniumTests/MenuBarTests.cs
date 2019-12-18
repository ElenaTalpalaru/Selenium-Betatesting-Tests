using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace SeleniumTests
{
    public class Tests
    {
        
        [Test]
        public void CheckPricingButton()
        {
            //Cream o instanta (obiect) de tipul IWebDriver
            IWebDriver driver;
            driver = new ChromeDriver(@"C:\Users\bogda\source\repos\SeleniumTests\SeleniumTests\Resurse\");

            try
            {
                // Ii dam valoarea ChromeDriver


                //Navigam la betatesting
                driver.Navigate().GoToUrl(@"https://betatesting.com/");

                //Marim fereastra
                driver.Manage().Window.Maximize();

                //Cautam butonul de pricing si il punem intr-o variabila de tip IWebElement
                IWebElement PricingTopButton = driver.FindElement(By.CssSelector(@"#customerMenu > ul > li:nth-child(3) > a"));

                //Dam clic pe buton
                PricingTopButton.Click();

                string totTextulDePePagina = driver.PageSource;
                Assert.IsTrue(totTextulDePePagina.Contains("Review our Pricing"));
                Assert.IsTrue(driver.Url == "https://betatesting.com/pricing");
            }
            finally
            {
                driver.Close();
            }



        }
        [Test]
        public void UseCasesTopButton()
        {
            IWebDriver driver;
            driver = new ChromeDriver(@"C:\Users\bogda\source\repos\SeleniumTests\SeleniumTests\Resurse\");

            driver.Navigate().GoToUrl(@"https://betatesting.com/");

            //Marim fereastra
            driver.Manage().Window.Maximize();
            IWebElement UseCasesButton = driver.FindElement(By.CssSelector("#useCasesMenu > a"));
            UseCasesButton.Click();
            Thread.Sleep(2000);
            string totTextulDePePagina = driver.PageSource;
            Assert.IsTrue(totTextulDePePagina.Contains("Explore how you can use BetaTesting to improve your product"));
            driver.Close();


        }

        [Test]
        public void LogoLinkButton()
        {
            //Cream o instanta (obiect) de tipul IWebDriver
            IWebDriver driver;
            driver = new ChromeDriver(@"C:\Users\bogda\source\repos\SeleniumTests\SeleniumTests\Resurse\");

            try
            {

                //Navigam la betatesting
                driver.Navigate().GoToUrl(@"https://betatesting.com/");

                //Marim fereastra
                driver.Manage().Window.Maximize();
                IWebElement LogoButton = driver.FindElement(By.CssSelector("#logo > a > img"));
                LogoButton.Click();
                string totTextulDePePagina = driver.PageSource;
                Assert.IsTrue(totTextulDePePagina.Contains("Beta Testing Solved"));
                Assert.IsTrue(driver.Url == "https://betatesting.com/");

            }
            finally

            { driver.Close();
            }

        }

    
        [Test]
        public void JoinAsBetaTesterLink()
        {
            IWebDriver driver;
            driver = new ChromeDriver(@"C:\Users\bogda\source\repos\SeleniumTests\SeleniumTests\Resurse\");
            try
            {
                driver.Navigate().GoToUrl(@"https://betatesting.com/");
                driver.Manage().Window.Maximize();
                IWebElement JoinAsBetaTester = driver.FindElement(By.CssSelector(@"#joinTopMenu"));
                JoinAsBetaTester.Click();
                string totTextulDePePagina = driver.PageSource;
                Assert.IsTrue(totTextulDePePagina.Contains("Test exciting new products "));
                Assert.IsTrue(driver.Url == "https://betatesting.com/beta-testers");

            }
            finally 
            {
                driver.Close();
                
            }           
        }

        [Test]
        public void SignInLink()
        {
            IWebDriver driver;
            driver = new ChromeDriver(@"C:\Users\bogda\source\repos\SeleniumTests\SeleniumTests\Resurse\");

            try
            {
                driver.Navigate().GoToUrl(@"https://betatesting.com/");
                driver.Manage().Window.Maximize();
                IWebElement SignInButton = driver.FindElement(By.CssSelector(@"#signIn > a:nth-child(3)"));
                SignInButton.Click();
                string totTextulDePePagina = driver.PageSource;
                Assert.IsTrue(totTextulDePePagina.Contains("login email address"));
                Assert.IsTrue(driver.Url == "https://betatesting.com/login");
            }
            finally 
            {

                driver.Close();
            }

        }

        
    }

}

