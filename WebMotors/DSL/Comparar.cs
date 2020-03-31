
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace WebMotors
{
    public static class Comparar
    {

        public static void CompararIgualId(IWebDriver driver, string valor, string elementoId)
        {

            try
            {
                IWebElement element = Util.ElementoPresente(driver, By.Id(elementoId));

                if (valor != element.Text)
                {
                    Assert.Fail("O valor " + valor + " é diferente de " + element.Text);
                }
                else
                {
                    Assert.AreEqual(valor, element.Text);
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }


        }
        public static void CompararIgualName(IWebDriver driver, string valor, string elementoName)
        {
            IWebElement element = Util.ElementoPresente(driver, By.Name(elementoName));

            if (valor != element.Text)
            {
                Assert.Fail("O valor " + valor + " é diferente de " + element.Text);
            }
            else
            {
                Assert.AreEqual(valor, element.Text);
                return;
            }
        }
        public static void CompararIgualClassName(IWebDriver driver, string valor, string elementoClassName)
        {
            try
            {
                IWebElement element = Util.ElementoPresente(driver, By.ClassName(elementoClassName));

                if (valor != element.Text)
                {
                    Assert.Fail("O valor " + valor + " é diferente de " + element.Text);
                }
                else
                {
                    Assert.AreEqual(valor, element.Text);
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }


        }
        public static void CompararIgualXpath(IWebDriver driver, string valor, string elementoXPath)
        {
            IWebElement element = Util.ElementoPresente(driver, By.XPath(elementoXPath));

            if (valor != element.Text)
            {
                Assert.Fail("O valor " + valor + " é diferente de " + element.Text);
            }
            else
            {
                Assert.AreEqual(valor, element.Text);
                return;
            }
        }
        public static void CompararIgualLinkText(IWebDriver driver, string valor, string elementoLinkText)
        {
            IWebElement element = Util.ElementoPresente(driver, By.LinkText(elementoLinkText));

            if (valor != element.Text)
            {
                Assert.Fail("O valor " + valor + " é diferente de " + element.Text);
            }
            else
            {
                Assert.AreEqual(valor, element.Text);
                return;
            }
        }
        public static void CompararIgualPartialLinkText(IWebDriver driver, string valor, string elementoPartialLinkText)
        {
            IWebElement element = Util.ElementoPresente(driver, By.PartialLinkText(elementoPartialLinkText));

            if (valor != element.Text)
            {
                Assert.Fail("O valor " + valor + " é diferente de " + element.Text);
            }
            else
            {
                Assert.AreEqual(valor, element.Text);
                return;
            }
        }
        public static void CompararIgualTagName(IWebDriver driver, string valor, string elementoTagName)
        {
            IWebElement element = Util.ElementoPresente(driver, By.TagName(elementoTagName));

            if (valor != element.Text)
            {
                Assert.Fail("O valor " + valor + " é diferente de " + element.Text);
            }
            else
            {
                Assert.AreEqual(valor, element.Text);
                return;
            }
        }
        public static void CompararIgualCssSelector(IWebDriver driver, string valor, string elementoCssSelector)
        {
            IWebElement element = Util.ElementoPresente(driver, By.CssSelector(elementoCssSelector));

            if (valor != element.Text)
            {
                Assert.Fail("O valor " + valor + " é diferente de " + element.Text);
            }
            else
            {
                Assert.AreEqual(valor, element.Text);
                return;
            }
        }

    }
}
