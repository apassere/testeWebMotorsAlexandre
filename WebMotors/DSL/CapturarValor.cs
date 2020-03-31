using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using System.Threading;

namespace WebMotors
{
    public static class CapturarValor
    {
        static IWebElement Element;
        static readonly int sleep = 500;
        public static string ElementoId(IWebDriver driver, string elementoId)
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
                        AguardarPaginaCarregar(driver);
                        Element = driver.FindElement(By.Id(elementoId));
                        if (!Element.Location.IsEmpty)
                        {
                            return Element.Text;
                        }
                        else { };
                    }
                    catch (Exception)
                    {
                        Element = null;
                        Thread.Sleep(sleep);
                        RetryCount--;
                    }
                }
            }
            catch (Exception)
            {
                Assert.Fail("Elemento" + " ' " + elementoId + " ' " + "não encontrado" + "Número de tentativas = " + RetryCount);
                throw;
            }
            return null;
        }
        public static string ElementoName(IWebDriver driver, string elementoName)
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
                        AguardarPaginaCarregar(driver);
                        Element = driver.FindElement(By.Name(elementoName));
                        if (!Element.Location.IsEmpty)
                        {
                            return Element.Text;
                        }
                        else { };
                    }
                    catch (Exception)
                    {
                        Element = null;
                        Thread.Sleep(sleep);
                        RetryCount--;
                    }
                }
            }
            catch (Exception)
            {
                Assert.Fail("Elemento" + " ' " + elementoName + " ' " + "não encontrado" + "Número de tentativas = " + RetryCount);
                throw;
            }
            return null;
        }
        public static string ElementoClassName(IWebDriver driver, string elementoClassName)
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
                        AguardarPaginaCarregar(driver);
                        Element = driver.FindElement(By.ClassName(elementoClassName));
                        if (!Element.Location.IsEmpty)
                        {
                            return Element.Text;
                        }
                        else { };
                    }
                    catch (Exception)
                    {
                        Element = null;
                        Thread.Sleep(sleep);
                        RetryCount--;
                    }
                }
            }
            catch (Exception)
            {
                Assert.Fail("Elemento" + " ' " + elementoClassName + " ' " + "não encontrado" + "Número de tentativas = " + RetryCount);
                throw;
            }
            return null;
        }
        public static string ElementoXpath(IWebDriver driver, string elementoXPath)
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
                        Util.AguardarPaginaCarregar(driver);
                        Element = driver.FindElement(By.XPath(elementoXPath));
                        if (!Element.Location.IsEmpty)
                        {
                            return Element.Text;
                        }
                        else { };
                    }
                    catch (Exception)
                    {
                        Element = null;
                        Thread.Sleep(sleep);
                        RetryCount--;
                    }
                }
            }
            catch (Exception)
            {
                Assert.Fail("Elemento" + " ' " + elementoXPath + " ' " + "não encontrado" + "Número de tentativas = " + RetryCount);
                throw;
            }
            return null;
        }
        public static string ElementoCssSelector(IWebDriver driver, string elementoCssSelector)
        {
            int RetryCount = 3;
            Element = null;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            while (RetryCount > 0)
            {
                RetryCount--;
                try
                {
                    wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(elementoCssSelector)));
                    AguardarPaginaCarregar(driver);
                    Element = driver.FindElement(By.CssSelector(elementoCssSelector));
                    if (!Element.Location.IsEmpty)
                    {
                        return Element.Text;
                    }
                    else { Thread.Sleep(sleep); };
                }
                catch (Exception)
                {
                    Element = null;
                    Assert.Fail("Elemento" + " ' " + elementoCssSelector + " ' " + "não encontrado" + "Número de tentativas = " + RetryCount);
                    throw;
                }
            }
            return null;
        }
        public static string ElementoLinkText(IWebDriver driver, string elementoLinkText)
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
                        AguardarPaginaCarregar(driver);
                        Element = driver.FindElement(By.LinkText(elementoLinkText));
                        if (!Element.Location.IsEmpty)
                        {
                            return Element.Text;
                        }
                        else {  };
                    }
                    catch (Exception)
                    {
                        Element = null;
                        Thread.Sleep(sleep);
                        RetryCount--;
                    }
                }
            }
            catch (Exception)
            {
                Assert.Fail("Elemento" + " ' " + elementoLinkText + " ' " + "não encontrado" + "Número de tentativas = " + RetryCount);
                throw;
            }
            
            return null;
        }
        public static string ElementoPartialLinkText(IWebDriver driver, string elementoPartialLinkText)
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
                        AguardarPaginaCarregar(driver);
                        Element = driver.FindElement(By.PartialLinkText(elementoPartialLinkText));
                        if (!Element.Location.IsEmpty)
                        {
                            return Element.Text;
                        }
                        else { };
                    }
                    catch (Exception)
                    {
                        Element = null;
                        Thread.Sleep(sleep);
                        RetryCount--;
                    }
                }
            }
            catch (Exception)
            {
                Assert.Fail("Elemento" + " ' " + elementoPartialLinkText + " ' " + "não encontrado" + "Número de tentativas = " + RetryCount);
                throw;
            }
            return null;
        }
        public static string ElementoTagName(IWebDriver driver, string elementoTagName)
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
                        wait.Until(ExpectedConditions.ElementToBeClickable(By.TagName(elementoTagName)));
                        AguardarPaginaCarregar(driver);
                        Element = driver.FindElement(By.TagName(elementoTagName));
                        if (!Element.Location.IsEmpty)
                        {
                            
                            return Element.Text;
                        }
                        else { };
                    }
                    catch (Exception)
                    {
                        Element = null;
                        Thread.Sleep(sleep);
                        RetryCount--;
                    }
                }
            }
            catch (Exception)
            {
                Assert.Fail("Elemento" + " ' " + elementoTagName + " ' " + "não encontrado" + "Número de tentativas = " + RetryCount);
                throw;
            }
            return null;
        }

        public static void AguardarPaginaCarregar(IWebDriver driver)

        {
            try
            {
                Thread.Sleep(100);
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
