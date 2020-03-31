#language: pt-BR
Funcionalidade: Consultar quantidade de veículos no estoque da loja
	Eu como usuário do sistema
	Desejo saber a lista de carros do estoque da loja

--Cenário 1
Cenario: Consultar estoque de veículos da loja
	Dado que um usuário acesse o estoque da loja pelo site WEBMOTORS
	Quando desejar verificar a quantidade de veículos do estoque
	Então o sistema retornará uma lista com os veículos em estoque
