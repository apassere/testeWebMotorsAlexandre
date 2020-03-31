using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace WebMotors
{
    public static class SelecionarValorCombo
    {
        static IWebElement element;
        static SelectElement selectElement;
        public static void SelecionarValorComboId(IWebDriver driver, string elementoId, string valor)
        {
            try
            {
                element = Util.ElementoPresente(driver, By.Id(elementoId));
                selectElement = new SelectElement(element);
                selectElement.SelectByValue(valor);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }


        }
        public static void CapturarValorName(IWebDriver driver, string elementoName, string valor)
        {
            element = Util.ElementoPresente(driver, By.Name(elementoName));
            selectElement.SelectByValue(valor);
        }
        public static void SelecionarValorComboClassName(IWebDriver driver, string elementoClassName, string valor)
        {
            element = Util.ElementoPresente(driver, By.ClassName(elementoClassName));
            selectElement.SelectByValue(valor);
        }
        public static void SelecionarValorComboXpath(IWebDriver driver, string elementoXPath, string valor)
        {
            element = Util.ElementoPresente(driver, By.XPath(elementoXPath));
            selectElement.SelectByValue(valor);
        }
        public static void SelecionarValorComboLinkText(IWebDriver driver, string elementoLinkText, string valor)
        {
            element = Util.ElementoPresente(driver, By.LinkText(elementoLinkText));
            selectElement.SelectByValue(valor);
        }
        public static void SelecionarValorComboPartialLinkText(IWebDriver driver, string elementoPartialLinkText, string valor)
        {
            element = Util.ElementoPresente(driver, By.PartialLinkText(elementoPartialLinkText));
            selectElement.SelectByValue(valor);
        }
        public static void SelecionarValorComboTagName(IWebDriver driver, string elementoTagName, string valor)
        {
            element = Util.ElementoPresente(driver, By.TagName(elementoTagName));
            selectElement.SelectByValue(valor);
        }
        public static void SelecionarValorComboCssSelector(IWebDriver driver, string elementoCssSelector, string valor)
        {
            element = Util.ElementoPresente(driver, By.CssSelector(elementoCssSelector));
            selectElement.SelectByValue(valor);
        }
    }
}
