using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace WebMotors
{
    public static class Wait
    {
        static IWebElement element;
        static WebDriverWait wait;

        public static void WaitElementId(IWebDriver driver, string elementoId)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id(elementoId)));
        }
        public static void WaitElementName(IWebDriver driver, string elementoName)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Name(elementoName)));
        }
        public static void WaitElementClassName(IWebDriver driver, string elementoClassName)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(elementoClassName)));
        }
        public static void WaitElementXpath(IWebDriver driver, string elementoXPath)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(elementoXPath)));
        }
        public static void WaitElementLinkText(IWebDriver driver, string elementoLinkText)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(elementoLinkText)));
        }
        public static void WaitElementPartialLinkText(IWebDriver driver, string elementoPartialLinkText)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText(elementoPartialLinkText)));
        }
        public static void WaitElementPTagName(IWebDriver driver, string elementoTagName)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.TagName(elementoTagName)));
        }
        public static void WaitElementPCssSelector(IWebDriver driver, string elementoCssSelector)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(elementoCssSelector)));
        }
    }
}
