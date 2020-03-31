using OpenQA.Selenium;

namespace WebMotors
{
    public static class Limpar
    {

        static IWebElement element;

        public static void LimparId(IWebDriver driver, string elementoId)
        {
            element = Util.ElementoPresente(driver, By.Id(elementoId));
            element.Clear();
        }
        public static void LimparName(IWebDriver driver, string elementoName)
        {
            element = Util.ElementoPresente(driver, By.Name(elementoName));
            element.Clear();
        }
        public static void LimparClassName(IWebDriver driver, string elementoClassName)
        {
            element = Util.ElementoPresente(driver, By.ClassName(elementoClassName));
            element.Clear();
        }
        public static void LimparXpath(IWebDriver driver, string elementoXPath)
        {
            element = Util.ElementoPresente(driver, By.XPath(elementoXPath));
            element.Clear();
        }
        public static void LimparLinkText(IWebDriver driver, string elementoLinkText)
        {
            element = Util.ElementoPresente(driver, By.LinkText(elementoLinkText));
            element.Clear();
        }
        public static void LimparPartialLinkText(IWebDriver driver, string elementoPartialLinkText)
        {
            element = Util.ElementoPresente(driver, By.PartialLinkText(elementoPartialLinkText));
            element.Clear();
        }
        public static void LimparTagName(IWebDriver driver, string elementoTagName)
        {
            element = Util.ElementoPresente(driver, By.TagName(elementoTagName));
            element.Clear();
        }
        public static void LimparCssSelector(IWebDriver driver, string elementoCssSelector)
        {
            element = Util.ElementoPresente(driver, By.CssSelector(elementoCssSelector));
            element.Clear();
        }

    }
}
