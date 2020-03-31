using System;

namespace WebMotors
{
    public static class Elementos
    {

        #region Home
        public static String Comprar { get { return "//li[contains(text(),'Comprar')]"; } }
        public static String ComprarCarrosUsadosOuSeminovos { get { return "//a[@id='navigationUsedOrNewCars']"; } }
        #endregion Home

        #region Consultar Carros Usados
        public static String Marca(string marca) {return "//small[contains(text(),'" + marca + "')]"; }
        public static String Modelo(string modelo) { return "//a[contains(text(),'" + modelo + "')]"; }
        public static String Versao(string versao) { return "//a[contains(text(),'" + versao + "')]"; }
        public static String TodosOsModelos { get { return "//div[contains(@class,'Filters__line Filters__line--gray Filters__line--icon Filters__line--icon--right')]"; } }
        public static String TodasAsVersoes { get { return "//div[@class='Filters__line Filters__line--icon Filters__line--icon Filters__line--icon--right Filters__line--gray']"; } }
        public static String AdicionarVeiculo { get { return "//div[@class='Filters__line Filters__line--add-vehicle Filters__line--icon Filters__line--icon--plus']"; } }
        public static String MensagemOk { get { return "//p[contains(text(),'carros encontrados')]"; } }
        public static String MensagemNok { get { return "//strong[contains(text(),'Ops, não encontramos nenhum carro como este!')]"; } }
        #endregion Consultar Carros Usados

    }
}

