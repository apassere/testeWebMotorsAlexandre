using OpenQA.Selenium;
using System;
using System.Collections.ObjectModel;
using TechTalk.SpecFlow;
using WebMotors.Pages;

namespace WebMotors.Steps
{
    [Binding]
    public class ConsultarQuantidadeDeVeiculosNoEstoqueDaLojaSteps
    {
        private static string url = "https://www.webmotors.com.br/carros/estoque?tipoveiculo=carros&anunciante=concession%C3%A1ria%7Cloja&idrevendedor=3834764";
        public IWebDriver Driver { get; set; }
        ConsultarCarros consultarCarros;
        ReadOnlyCollection<IWebElement> lista;

        [Given(@"que um usuário acesse o estoque da loja pelo site WEBMOTORS")]
        public IWebDriver DadoQueUmUsuarioAcesseOEstoqueDaLojaPeloSiteWEBMOTORS()
        {
            Driver = Util.AcessarSite(url);
            return Driver;
        }
        
        [When(@"desejar verificar a quantidade de veículos do estoque")]
        public void QuandoDesejarVerificarAQuantidadeDeVeiculosDoEstoque()
        {
            consultarCarros = new ConsultarCarros(Driver);
            consultarCarros.ConsultarQuantidadeDeCarrosNoEstoque();
            
        }
        
        [Then(@"o sistema retornará uma lista com os veículos em estoque")]
        public void EntaoOSistemaRetornaraUmaListaComOsVeiculosEmEstoque()
        {
            consultarCarros.ImprimirListaDeCarros();
        }
    }
}
