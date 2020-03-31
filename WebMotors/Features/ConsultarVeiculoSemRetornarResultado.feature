#language: pt-BR

Funcionalidade: Consultar veículos sem retornar resultado
	Eu como usuário do sistema
	Para garantir que os filtros Marca de Carro estão funcionando corretamente
	Desejo que apresentem veículos somente das marcas que estou buscando

--Cenário 1

Cenario: Consultar veículo sem retornar resultado
	Dado que um usuário acesse o site WEBMOTORS
	Quando desejar realizar consulta de veiculos
	E informar os dados Marca <marca>, Modelo <modelo> e Versão <versao>,
	Então o sistema exibirá mensagem <mensagem> de erro de pesquisa.

	    Exemplos:
    |   marca    |   modelo    |             versao                             | mensagem                                     |
    | chevrolet  | CAPTIVA     | 2.4 SFI ECOTEC FWD 16V GASOLINA 4P AUTOMÁTICO  | carros encontrados                           |
