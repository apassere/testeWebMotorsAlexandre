using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using System.Threading;

namespace WebMotors
{
    public static class Clicar
    {
        static IWebElement Element;
        static readonly int sleep = 1500;
        static readonly int contador = 10;

        public static void ElementoId(IWebDriver driver, string elementoId)
        {
            int RetryCount = 3;
            Element = null;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            try
            {
                while (RetryCount > 0)
                {

                    try
                    {
                        wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(elementoId)));
                        Element = driver.FindElement(By.Id(elementoId));
                        if (!Element.Location.IsEmpty)
                        {
                            int cont = 3;
                            while (cont > 0)
                            {
                                try
                                {
                                    Element.Click();
                                    AguardarPaginaCarregar(driver);
                                    break;
                                }
                                catch (Exception)
                                {
                                    Thread.Sleep(500);
                                    cont--;
                                }
                            }

                            break;
                        }
                        else { }
                    }
                    catch (Exception)
                    {
                        Element = null;
                        RetryCount--;
                        Thread.Sleep(sleep);
                    }
                }
            }
            catch (Exception)
            {
                Assert.Fail("Elemento" + " ' " + elementoId + " ' " + "não encontrado" + "Número de tentativas = " + RetryCount);
                throw;
            }
        }
        public static void ElementoName(IWebDriver driver, string elementoName)
        {
            int RetryCount = 3;
            Element = null;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            try
            {
                while (RetryCount > 0)
                {

                    try
                    {
                        wait.Until(ExpectedConditions.ElementToBeClickable(By.Name(elementoName)));
                        Element = driver.FindElement(By.Name(elementoName));
                        if (!Element.Location.IsEmpty)
                        {
                            int cont = 3;
                            while (cont > 0)
                            {
                                try
                                {
                                    AguardarPaginaCarregar(driver);
                                    Element.Click();
                                    AguardarPaginaCarregar(driver);
                                    break;
                                }
                                catch (Exception)
                                {
                                    Thread.Sleep(500);
                                    cont--;
                                }
                            }

                            break;
                        }
                        else { }
                    }
                    catch (Exception)
                    {
                        Element = null;
                        RetryCount--;
                        Thread.Sleep(sleep);
                    }
                }
            }
            catch (Exception)
            {
                Assert.Fail("Elemento" + " ' " + elementoName + " ' " + "não encontrado" + "Número de tentativas = " + RetryCount);
                throw;
            }
        }
        public static void ElementoClassName(IWebDriver driver, string elementoClassName)
        {
            int RetryCount = 3;
            Element = null;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            try
            {
                while (RetryCount > 0)
                {

                    try
                    {
                        wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName(elementoClassName)));
                        Element = driver.FindElement(By.ClassName(elementoClassName));
                        if (!Element.Location.IsEmpty)
                        {
                            int cont = 3;
                            while (cont > 0)
                            {
                                try
                                {
                                    Element.Click();
                                    AguardarPaginaCarregar(driver);
                                    break;
                                }
                                catch (Exception)
                                {
                                    Thread.Sleep(500);
                                    cont--;
                                }
                            }

                            break;
                        }
                        else { }
                    }
                    catch (Exception)
                    {
                        Element = null;
                        RetryCount--;
                        Thread.Sleep(sleep);
                    }
                }
            }
            catch (Exception)
            {
                Assert.Fail("Elemento" + " ' " + elementoClassName + " ' " + "não encontrado" + "Número de tentativas = " + RetryCount);
                throw;
            }
        }
        public static void ElementoXpath(IWebDriver driver, string elementoXPath)
        {
            int RetryCount = 3;
            Element = null;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            try
            {
                while (RetryCount > 0)
                {

                    try
                    {
                        wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(elementoXPath)));
                        Element = driver.FindElement(By.XPath(elementoXPath));
                        if (!Element.Location.IsEmpty)
                        {
                            int cont = 3;
                            while (cont > 0)
                            {
                                try
                                {
                                    Element.Click();
                                    AguardarPaginaCarregar(driver);
                                    break;
                                }
                                catch (Exception)
                                {
                                    Thread.Sleep(500);
                                    cont--;
                                }
                            }

                            break;
                        }
                        else { }
                    }
                    catch (Exception)
                    {
                        Element = null;
                        RetryCount--;
                        Thread.Sleep(sleep);
                    }
                }
            }
            catch (Exception)
            {
                Assert.Fail("Elemento" + " ' " + elementoXPath + " ' " + "não encontrado" + "Número de tentativas = " + RetryCount);
                throw;
            }
        }
        public static void ElementoCssSelector(IWebDriver driver, string elementoCssSelector)
        {
            int RetryCount = 3;
            Element = null;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            try
            {
                while (RetryCount > 0)
                {
                    
                    try
                    {
                        wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(elementoCssSelector)));
                        Element = driver.FindElement(By.CssSelector(elementoCssSelector));
                        if (!Element.Location.IsEmpty)
                        {
                            int cont = 3;
                            while (cont > 0)
                            {
                                try
                                {
                                    Element.Click();
                                    AguardarPaginaCarregar(driver);
                                    break;
                                }
                                catch (Exception)
                                {
                                    Thread.Sleep(500);
                                    cont--;
                                }
                            }

                            break;
                        }
                        else { }
                    }
                    catch (Exception)
                    {
                        Element = null;
                        RetryCount--;
                        Thread.Sleep(sleep);
                    }
                }
            }
            catch (Exception)
            {
                Assert.Fail("Elemento" + " ' " + elementoCssSelector + " ' " + "não encontrado" + "Número de tentativas = " + RetryCount);
                throw;
            }
            
            
        }
        public static void ElementoLinkText(IWebDriver driver, string elementoLinkText)
        {
            int RetryCount = 3;
            Element = null;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            try
            {
                while (RetryCount > 0)
                {

                    try
                    {
                        wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText(elementoLinkText)));
                        Element = driver.FindElement(By.LinkText(elementoLinkText));
                        if (!Element.Location.IsEmpty)
                        {
                            int cont = 3;
                            while (cont > 0)
                            {
                                try
                                {
                                    Element.Click();
                                    AguardarPaginaCarregar(driver);
                                    break;
                                }
                                catch (Exception)
                                {
                                    Thread.Sleep(500);
                                    cont--;
                                }
                            }

                            break;
                        }
                        else { }
                    }
                    catch (Exception)
                    {
                        Element = null;
                        RetryCount--;
                        Thread.Sleep(sleep);
                    }
                }
            }
            catch (Exception)
            {
                Assert.Fail("Elemento" + " ' " + elementoLinkText + " ' " + "não encontrado" + "Número de tentativas = " + RetryCount);
                throw;
            }
        }
        public static void ElementoPartialLinkText(IWebDriver driver, string elementoPartialLinkText)
        {
            int RetryCount = 3;
            Element = null;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            try
            {
                while (RetryCount > 0)
                {

                    try
                    {
                        wait.Until(ExpectedConditions.ElementToBeClickable(By.PartialLinkText(elementoPartialLinkText)));
                        Element = driver.FindElement(By.PartialLinkText(elementoPartialLinkText));
                        if (!Element.Location.IsEmpty)
                        {
                            int cont = 3;
                            while (cont > 0)
                            {
                                try
                                {
                                    Element.Click();
                                    AguardarPaginaCarregar(driver);
                                    break;
                                }
                                catch (Exception)
                                {
                                    Thread.Sleep(500);
                                    cont--;
                                }
                            }

                            break;
                        }
                        else { }
                    }
                    catch (Exception)
                    {
                        Element = null;
                        RetryCount--;
                        Thread.Sleep(sleep);
                    }
                }
            }
            catch (Exception)
            {
                Assert.Fail("Elemento" + " ' " + elementoPartialLinkText + " ' " + "não encontrado" + "Número de tentativas = " + RetryCount);
                throw;
            }
        }
        public static void ElementoTagName(IWebDriver driver, string elementoTagName)
        {
            int RetryCount = contador;
            Element = null;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            try
            {
                while (RetryCount > 0)
                {

                    try
                    {
                        wait.Until(ExpectedConditions.ElementToBeClickable(By.TagName(elementoTagName)));
                        Element = driver.FindElement(By.TagName(elementoTagName));
                        if (!Element.Location.IsEmpty)
                        {
                            int cont = 3;
                            while (cont>0)
                            {
                                try
                                {
                                    Element.Click();
                                    AguardarPaginaCarregar(driver);
                                    break;
                                }
                                catch (Exception)
                                {
                                    Thread.Sleep(500);
                                    cont--;
                                }
                            }

                            break;

                        }
                        else { }
                    }
                    catch (Exception)
                    {
                        Element = null;
                        RetryCount--;
                        Thread.Sleep(sleep);
                    }
                }
            }
            catch (Exception)
            {
                Assert.Fail("Elemento" + " ' " + elementoTagName + " ' " + "não encontrado" + "Número de tentativas = " + RetryCount);
                throw;
            }
        }

        public static void AguardarPaginaCarregar(IWebDriver driver)

        {
            try
            {
                Thread.Sleep(1000);
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
    }
}
