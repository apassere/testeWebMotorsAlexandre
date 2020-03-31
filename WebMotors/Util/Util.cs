using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Threading;

namespace WebMotors
{
    public static class Util
    {
        //public static RemoteWebDriver DriverRemoto { get; set; }
        public static WebDriverWait wait;
        private static RemoteWebDriver DriverRemoto { get; set; }

        private static IWebDriver Driver { get; set; }

        [SetUp]
        public static RemoteWebDriver IniciarDriverRemoto(string enderecoAplicacao)
        {
            var dc = new DesiredCapabilities();
            dc.SetCapability("app", enderecoAplicacao);
            DriverRemoto = new RemoteWebDriver(new Uri("http://localhost:9999"), dc);
            return DriverRemoto;

        }

        public static bool IsElementPresent(By by)
        {
            try
            {
                Driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        //[SetUp]
        //public static RemoteWebDriver IniciarDriverRemoto(string enderecoAplicacao)
        //{
        //    var options = new AppiumOptions();
        //    options.AddAdditionalCapability("app", enderecoAplicacao);
        //    DriverRemoto = new RemoteWebDriver(new Uri("http://127.0.0.1:4723"), options);
        //    DriverRemoto.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        //    return DriverRemoto;
        //}

        [TearDown]
        public static void FinalizarDriver()
        {

            DriverRemoto.Quit();
        }
        public static IWebDriver IniciarDriver()
        {
            return new ChromeDriver();
        }
        public static IWebDriver AcessarSite(string url)
        {
            IWebDriver driver = IniciarDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            return driver;
        }
        public static IWebElement ElementoPresente(IWebDriver driver, By by)
        {
            try
            {
                IWebElement element = driver.FindElement(by);


                return element;
            }
            catch (Exception ex)
            {
                IWebElement element = null;
                Assert.Fail("Elemento" + " ' " + by + " ' " + "não encontrado");
                throw;
            }
        }

        public static void AguardarPaginaCarregar(IWebDriver driver)

        {
            try
            {
                Thread.Sleep(2000);
                IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                wait.Until(driver1 => (string)((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState") == "complete");

                ReadOnlyCollection<IWebElement> elements = driver.FindElements(By.Id("webWidget"));

                foreach (IWebElement element in elements)
                {
                    IWebElement parenet = element.FindElement(By.XPath("./.."));
                    //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].style='none'", element);
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].setAttribute('style', 'display:none')", parenet);
                }
            }
            catch (Exception)
            {


            }

        }

        public static void AguardarCarregarSupplyChainAdvantage(IWebDriver driver)

        {

            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(driver1 => (string)((IJavaScriptExecutor)driver).ExecuteScript("return $('.action-group supply-chain-advantage disabled').selector") != ".action-group supply-chain-advantage disabled");

            ReadOnlyCollection<IWebElement> elements = driver.FindElements(By.Id("webWidget"));

            foreach (IWebElement element in elements)
            {
                IWebElement parenet = element.FindElement(By.XPath("./.."));
                //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].style='none'", element);
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].setAttribute('style', 'display:none')", parenet);
            }


        }

        public static void AguardarGridCarregar(IWebDriver driver)

        {

            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(driver1 => (Int64)((IJavaScriptExecutor)driver).ExecuteScript("return $('.hj-overlay-layer').length") == 0);

            ReadOnlyCollection<IWebElement> elements = driver.FindElements(By.Id("webWidget"));

            foreach (IWebElement element in elements)
            {
                IWebElement parenet = element.FindElement(By.XPath("./.."));
                //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].style='none'", element);
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].setAttribute('style', 'display:none')", parenet);
            }


        }


        public static void CriarNovaAba(IWebDriver driver, string url)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open('', 'ChildWindow');");
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.Navigate().GoToUrl(url);
        }
        public static void Screenshot(IWebDriver driver, string screenshotsPasta)
        {
            ITakesScreenshot camera = driver as ITakesScreenshot;
            Screenshot foto = camera.GetScreenshot();
            foto.SaveAsFile(screenshotsPasta, ScreenshotImageFormat.Png);
        }

        public static RemoteWebElement ElementoRemotoPresente(RemoteWebDriver driver, By by)
        {
            try
            {
                RemoteWebElement element = (RemoteWebElement)driver.FindElement(by);
                return element;
            }
            catch (Exception ex)
            {
                RemoteWebElement element = null;
                Console.WriteLine(ex);
                Assert.Fail("Elemento não encontrado");
                return element;
            }
        }






        public static string Url { get; set; }


        public static object WebDriveChrome { get; private set; }

        public static IWebDriver ChromeDriver()
        {
            return new ChromeDriver();
        }

        //public static void Screenshot(IWebDriver driver, string screenshotsPasta)
        //{
        //    ITakesScreenshot camera = driver as ITakesScreenshot;
        //    Screenshot foto = camera.GetScreenshot();
        //    foto.SaveAsFile(screenshotsPasta, ScreenshotImageFormat.Png);
        //}

        public static void Print(IWebDriver driver, string file_name)
        {
            Screenshot(driver, Path.Combine(Path.Combine(Diretorio, "evidencias"), file_name));
        }

        public static string[] ReadTransferOrderCSV(string csv_file)
        {
            StreamReader streamreader = new StreamReader(csv_file);
            string order_numbers = streamreader.ReadToEnd().Replace("\r\n", "").Replace(" ", "");
            if (order_numbers.Contains(","))
            {
                return order_numbers.Split(',');
            }
            else if (order_numbers.Contains(";"))
            {
                return order_numbers.Split(';');
            }
            else
            {
                throw new System.Exception("Arquivo precisa ser delimitado por ';' ou ','");
            }
        }


        public static bool IsElementPresent(IWebDriver driver, By by)
        {
            try
            {
                IWebElement element = driver.FindElement(by);

                //1
                if (element == null)
                {
                    return false;
                }
                else
                {
                    return (element.Enabled);
                }

                //2
                //return element.Displayed;

                //3
                //return element.Enabled;

                //4
                //return (element.Displayed && element.Enabled);


                // nao adequada
                //return element.Location.IsEmpty;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static string Diretorio { get { return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); } }
        //public static Config Load_Config(string file_name)
        //{
        //    string config_data = File.ReadAllText(Path.Combine(Diretorio, file_name));
        //    Config config = JsonConvert.DeserializeObject<Config>(config_data);
        //    return config;
        //}
        //public static ConfigListaItens Load_Config_Itens(string file_name)
        //{
        //    string config_data = File.ReadAllText(Path.Combine(Diretorio, file_name));
        //    ConfigListaItens configListaItens = JsonConvert.DeserializeObject<ConfigListaItens>(config_data);
        //    return configListaItens;
        //}





    }
}
