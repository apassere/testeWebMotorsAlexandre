using OpenQA.Selenium;

namespace WebMotors
{
    public static class Digitar
    {
        static IWebElement element;

        public static void DigitarId(IWebDriver driver, string elementoId, string valor)
        {
            element = Util.ElementoPresente(driver, By.Id(elementoId));
            element.SendKeys(valor);
        }
        public static void DigitarName(IWebDriver driver, string elementoName, string valor)
        {
            element = Util.ElementoPresente(driver, By.Name(elementoName));
            element.SendKeys(valor);
        }
        public static void DigitarClassName(IWebDriver driver, string elementoClassName, string valor)
        {
            element = Util.ElementoPresente(driver, By.ClassName(elementoClassName));
            element.SendKeys(valor);
        }
        public static void DigitarXpath(IWebDriver driver, string elementoXPath, string valor)
        {
            element = Util.ElementoPresente(driver, By.XPath(elementoXPath));
            element.SendKeys(valor);
        }
        public static void DigitarLinkText(IWebDriver driver, string elementoLinkText, string valor)
        {
            element = Util.ElementoPresente(driver, By.LinkText(elementoLinkText));
            element.SendKeys(valor);
        }
        public static void DigitarPartialLinkText(IWebDriver driver, string elementoPartialLinkText, string valor)
        {
            element = Util.ElementoPresente(driver, By.PartialLinkText(elementoPartialLinkText));
            element.SendKeys(valor);
        }
        public static void DigitarTagName(IWebDriver driver, string elementoTagName, string valor)
        {
            element = Util.ElementoPresente(driver, By.PartialLinkText(elementoTagName));
            element.SendKeys(valor);
        }
        public static void DigitarCssSelector(IWebDriver driver, string elementoCssSelector, string valor)
        {
            element = Util.ElementoPresente(driver, By.CssSelector(elementoCssSelector));
            element.SendKeys(valor);
        }
    }
}
