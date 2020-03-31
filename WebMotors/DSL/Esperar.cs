using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace WebMotors
{
    public static class Esperar
    {
        public static IWebDriver driver;
        public static WebDriverWait wait;
        public static int segundos = 60;


        public static void EsperarElementoExisteId(IWebDriver driver, string elementoId)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(segundos));
            wait.Until(ExpectedConditions.ElementExists(By.Id(elementoId)));
        }

        public static void EsperarElementoExisteName(IWebDriver driver, string elementoName)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(segundos));
            wait.Until(ExpectedConditions.ElementExists(By.Name(elementoName)));
        }

        public static void EsperarElementoExisteClassName(IWebDriver driver, string elementoClassName)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(segundos));
            wait.Until(ExpectedConditions.ElementExists(By.ClassName(elementoClassName)));
        }

        public static void EsperarElementoExisteXPath(IWebDriver driver, string elementoXPath)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(segundos));
            wait.Until(ExpectedConditions.ElementExists(By.XPath(elementoXPath)));
        }

        public static void EsperarElementoExisteLinkText(IWebDriver driver, string elementoLinkText)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(segundos));
            wait.Until(ExpectedConditions.ElementExists(By.LinkText(elementoLinkText)));
        }

        public static void EsperarElementoExistePartialLinkText(IWebDriver driver, string elementoPartialLinkText)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(segundos));
            wait.Until(ExpectedConditions.ElementExists(By.PartialLinkText(elementoPartialLinkText)));
        }
        public static void EsperarElementoExisteCssSelector(IWebDriver driver, string elementoCssSelector)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(segundos));
            wait.Until(ExpectedConditions.ElementExists(By.CssSelector(elementoCssSelector)));
        }



        public static void EsperarElementoVisivelId(IWebDriver driver, string elementoId)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(segundos));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id(elementoId)));
        }

        public static void EsperarElementoVisivelName(IWebDriver driver, string elementoName)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(segundos));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Name(elementoName)));
        }

        public static void EsperarElementoVisivelClassName(IWebDriver driver, string elementoClassName)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(segundos));
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(elementoClassName)));
        }

        public static void EsperarElementoVisivelXPath(IWebDriver driver, string elementoXPath)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(segundos));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(elementoXPath)));
        }

        public static void EsperarElementoVisivelLinkText(IWebDriver driver, string elementoLinkText)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(segundos));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(elementoLinkText)));
        }

        public static void EsperarElementoVisivelPartialLinkText(IWebDriver driver, string elementoPartialLinkText)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(segundos));
            wait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText(elementoPartialLinkText)));
        }
        public static void EsperarElementoVisivelCssSelector(IWebDriver driver, string elementoCssSelector)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(segundos));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(elementoCssSelector)));
        }




        public static void EsperaElementoClicavelId(IWebDriver driver, string elementoId)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(segundos));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(elementoId)));
        }
        public static void EsperaElementoClicavelName(IWebDriver driver, string elementoName)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Name(elementoName)));
        }
        public static void EsperaElementoClicavelClassName(IWebDriver driver, string elementoClassName)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(segundos));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName(elementoClassName)));
        }
        public static void EsperaElementoClicavelCssSelector(IWebDriver driver, string elementoCssSelector)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(segundos));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(elementoCssSelector)));
        }
        public static void EsperaElementoClicavelXPath(IWebDriver driver, string elementoXPath)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(segundos));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(elementoXPath)));
        }
        public static void EsperaElementoClicavelLinkText(IWebDriver driver, string elementoLinkText)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(segundos));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText(elementoLinkText)));
        }
        public static void EsperaElementoClicavelPartialLinkText(IWebDriver driver, string elementoPartialLinkText)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(segundos));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.PartialLinkText(elementoPartialLinkText)));
        }

        public static void EsperaFluenteId(IWebDriver driver, string elementoId)
        {
            bool exitLoop = false;

            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(90);
            fluentWait.PollingInterval = TimeSpan.FromSeconds(90);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement searchResult;
            while (!exitLoop)
            {
                try
                {

                    searchResult = fluentWait.Until(x => x.FindElement(By.Id(elementoId)));


                    if (searchResult.Displayed == true)
                    {
                        exitLoop = true;
                        break;
                    }
                    else
                    {
                        exitLoop = false;
                    }

                }
                catch (Exception)
                {
                    exitLoop = false;
                }

            }
        }

        public static void EsperaFluenteName(IWebDriver driver, string elementoName)
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(90);
            fluentWait.PollingInterval = TimeSpan.FromSeconds(90);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement searchResult = fluentWait.Until(x => x.FindElement(By.Name(elementoName)));
        }

        public static void EsperaFluenteClassName(IWebDriver driver, string elementoClassName)
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(90);
            fluentWait.PollingInterval = TimeSpan.FromSeconds(90);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement searchResult = fluentWait.Until(x => x.FindElement(By.ClassName(elementoClassName)));
        }

        public static void EsperaFluenteCssSelector(IWebDriver driver, string elementoCssSelector)
        {
            bool exitLoop = false;
            
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(90);
            fluentWait.PollingInterval = TimeSpan.FromSeconds(90);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement searchResult;
            while (!exitLoop)
            {
                try
                {

                    searchResult = fluentWait.Until(x => x.FindElement(By.CssSelector(elementoCssSelector)));

                    
                    if (searchResult.Displayed == true)
                    {
                        exitLoop = true;
                        break;
                    }
                    else
                    {
                        exitLoop = false;
                    }

                }
                catch (Exception)
                {
                    exitLoop = false;
                }
                
            }

            



        }

        public static void EsperaFluenteXPath(IWebDriver driver, string elementoXPath)
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(90);
            fluentWait.PollingInterval = TimeSpan.FromSeconds(90);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement searchResult = fluentWait.Until(x => x.FindElement(By.XPath(elementoXPath)));
        }

        public static void EsperaFluenteLinkText(IWebDriver driver, string elementoLinkText)
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(90);
            fluentWait.PollingInterval = TimeSpan.FromSeconds(90);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement searchResult = fluentWait.Until(x => x.FindElement(By.LinkText(elementoLinkText)));
        }



    }
}
