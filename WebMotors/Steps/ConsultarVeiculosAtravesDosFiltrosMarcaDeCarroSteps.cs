using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using WebMotors.Pages;

namespace WebMotors
{
    [Binding]
    public class ConsultarVeiculosAtravesDosFiltrosMarcaDeCarroSteps
    {
        private static string url = "https://www.webmotors.com.br";
        public IWebDriver Driver { get; set; }
        ConsultarCarros consultarCarros;

        [Given(@"que um usuário acesse o site WEBMOTORS")]
        public IWebDriver DadoQueUmUsuarioAcesseOSiteWEBMOTORS()
        {
            Driver = Util.AcessarSite(url);
            return Driver;
        }
        
        [When(@"desejar realizar consulta de veiculos")]
        public void DadoDesejaRealizarConsultaDeVeiculos()
        {
            Home home = new Home(Driver);
            home.ComprarCarrosUsadosOuSeminovos();
        }
        
        [When(@"informar os dados Marca (.*), Modelo (.*) e Versão (.*),")]
        public void QuandoInformarOsDadosMarcaModeloEVersao(string marca, string modelo, string versao)
        {
            consultarCarros = new ConsultarCarros(Driver);
            consultarCarros.ConsultarCarrosUsados(marca, modelo, versao);
        }
        
        [When(@"adicionar um novo veículo no filtro de pesquisa,")]
        public void QuandoAdicionarUmNovoVeiculoNoFiltroDePesquisa()
        {
            consultarCarros = new ConsultarCarros(Driver);
            consultarCarros.AdicionarMaisUmVeiculo();
        }
        
        [When(@"informar os dados Marca (.*), Modelo (.*) e Versão (.*) do segundo veículo,")]
        public void QuandoInformarOsDadosMarcaModeloEVersaoDoSegundoVeiculo(string marca, string modelo, string versao)
        {
            consultarCarros = new ConsultarCarros(Driver);
            consultarCarros.ConsultarCarrosUsados(marca, modelo, versao);
        }
        
        [Then(@"o sistema exibirá o resultado da pesquisa com a mensagem (.*)")]
        public void EntaoOSistemaExibiraOResultadoDaPesquisaComAMensagem(string mensagem)
        {
            consultarCarros = new ConsultarCarros(Driver);
            consultarCarros.MensagemRetornoPositivo(mensagem);
        }

        [Then(@"o sistema exibirá mensagem (.*) de erro de pesquisa.")]
        public void EntaoOSistemaExibiraMensagemDeErroDePesquisa(string mensagem)
        {
            consultarCarros = new ConsultarCarros(Driver);
            consultarCarros.MensagemSemResultado(mensagem);
        }
    }
}
