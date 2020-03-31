using OpenQA.Selenium;
using System;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace WebMotors.Pages
{
    public class ConsultarCarros
    {
        public IWebDriver Driver;
        ReadOnlyCollection<IWebElement> elements;
        public ConsultarCarros(IWebDriver driver)
        {
            this.Driver = driver;
        }

        public void ConsultarCarrosUsados(string marca, string modelo, string versao)
        {
            //Selecionar Marca
            Clicar.ElementoXpath(Driver, Elementos.Marca(marca));

            //Clicar no Menu Todos os modelos
            Clicar.ElementoXpath(Driver, Elementos.TodosOsModelos);

            //Selecionar Modelo
            Clicar.ElementoXpath(Driver, Elementos.Modelo(modelo));

            //Clicar no Menu Todas as versões
            Clicar.ElementoXpath(Driver, Elementos.TodasAsVersoes);

            //Selecionar Versão
            Clicar.ElementoXpath(Driver, Elementos.Versao(versao));

        }

        public void AdicionarMaisUmVeiculo()
        {
            Clicar.ElementoXpath(Driver, Elementos.AdicionarVeiculo);
        }

        public void MensagemRetornoPositivo(string mensagem)
        {
            //Verificar Mensagem de retorno
            Comparar.CompararIgualXpath(Driver, mensagem, Elementos.MensagemOk);
        }

        public void MensagemSemResultado(string mensagem)
        {
            //Verificar Mensagem de retorno
            Comparar.CompararIgualXpath(Driver, mensagem, Elementos.MensagemNok);
        }

        public ReadOnlyCollection<IWebElement> ConsultarQuantidadeDeCarrosNoEstoque()
        {
            
            elements = Driver.FindElements(By.ClassName("sc-cHGsZl hdoeUh"));
            return elements;
        }

        public void ImprimirListaDeCarros()
        {
            int i = 0;
            while (elements.Count < 0)
            {
                Console.WriteLine(elements[i].Text);
            }

        }
    }

}
