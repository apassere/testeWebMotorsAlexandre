#language: pt-BR

Funcionalidade: Consultar dois veículos através dos filtros Marca de Carro
	Eu como usuário do sistema
	Para garantir que os filtros Marca de Carro estão funcionando corretamente
	Desejo que apresentem veículos somente das marcas que estou buscando

--Cenário 1

Cenario: Consultar dois veículos informando os filtros Marca, Modelo e Versão
	Dado que um usuário acesse o site WEBMOTORS
	Quando desejar realizar consulta de veiculos
	E informar os dados Marca <marca1>, Modelo <modelo1> e Versão <versao1>,
	E adicionar um novo veículo no filtro de pesquisa,
	E informar os dados Marca <marca2>, Modelo <modelo2> e Versão <versao2>,
	Então o sistema exibirá o resultado da pesquisa com a mensagem <mensagem>

	    Exemplos:
    |   marca1   |   modelo1   |               versao1                          |   marca2   |   modelo2   |               versao2                          | mensagem                                     |
    | chevrolet  | CAPTIVA     | 2.4 SFI ECOTEC FWD 16V GASOLINA 4P AUTOMÁTICO  | ford	     | EDGE        | 3.5 V6 GASOLINA SEL AUTOMÁTICO                 | carros encontrados                           |
