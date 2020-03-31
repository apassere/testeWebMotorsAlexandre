using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMotors.Pages
{
    public class Home
    {
        private IWebDriver Driver;

        public Home(IWebDriver driver)
        {
            this.Driver = driver;
        }

        public void ComprarCarrosUsadosOuSeminovos()
        {

            try
            {
                //Acessar o menu Carros
                Clicar.ElementoXpath(Driver, Elementos.Comprar);

                //Acessar o menu Comprar Carros Usados ou Seminovos
                Clicar.ElementoXpath(Driver, Elementos.ComprarCarrosUsadosOuSeminovos);

                //Trocar de Aba
                Driver.SwitchTo().Window(Driver.WindowHandles.Last());

                //Aguardar Carregar Página
                Util.AguardarPaginaCarregar(Driver);
            }
            catch (System.Exception e)
            {
                throw;
            }
            
        }
    }
}
