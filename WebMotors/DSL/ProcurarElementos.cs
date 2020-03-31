using OpenQA.Selenium;

namespace WebMotors
{
    public static class ProcurarElementos
    {
        static System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> elements;
        public static int QuantidadeElementosID(IWebDriver driver, string elementoId)
        {
            elements = driver.FindElements(By.XPath(elementoId));
            return elements.Count;
        }
        public static int QuantidadeElementosName(IWebDriver driver, string elementoName)
        {
            elements = driver.FindElements(By.XPath(elementoName));
            return elements.Count;
        }
        public static int QuantidadeElementosClassName(IWebDriver driver, string elementoClassName)
        {
            elements = driver.FindElements(By.XPath(elementoClassName));
            return elements.Count;
        }
        public static int QuantidadeElementosXPath(IWebDriver driver, string elementoXPath)
        {
            elements = driver.FindElements(By.XPath(elementoXPath));
            return elements.Count;
        }
        public static int QuantidadeElementosLinkText(IWebDriver driver, string elementoLinkText)
        {
            elements = driver.FindElements(By.XPath(elementoLinkText));
            return elements.Count;
        }
        public static int QuantidadeElementosPartialLinkText(IWebDriver driver, string elementoPartialLinkText)
        {
            elements = driver.FindElements(By.XPath(elementoPartialLinkText));
            return elements.Count;
        }
        public static int QuantidadeElementosTagName(IWebDriver driver, string elementoTagName)
        {
            elements = driver.FindElements(By.XPath(elementoTagName));
            return elements.Count;
        }
        public static int QuantidadeElementosCssSelector(IWebDriver driver, string elementoCssSelector)
        {
            elements = driver.FindElements(By.XPath(elementoCssSelector));
            return elements.Count;
        }
    }
}
