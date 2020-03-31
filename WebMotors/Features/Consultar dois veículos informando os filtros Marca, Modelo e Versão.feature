#language: pt-BR

Funcionalidade: Consultar veículos através dos filtros Marca de Carro
	Eu como usuário do sistema
	Para garantir que os filtros Marca de Carro estão funcionando corretamente
	Desejo que apresentem veículos somente das marcas que estou buscando

--Cenário 1
Cenario: Consultar veículos, informando os filtros Marca de Carro
	Dado que um usuário acesse o site WEBMOTORS
	Quando desejar realizar consulta de veiculos
	E informar os dados Marca <marca>, Modelo <modelo> e Versão <versao>,
	Então o sistema exibirá o resultado da pesquisa com a mensagem <mensagem>

	    Exemplos:
    |   marca   |   modelo   |               versao                          | mensagem                                     |
    | honda     | CITY       | HONDA CITY 1.5 DX 16V FLEX 4P MANUAL          | carros encontrados                           |
    | ford	    | EDGE       | 3.5 V6 GASOLINA SEL AUTOMÁTICO                | carros encontrados                           |    