Funcionalidade: Usu�rio - Cadastro
	Como um visitante da loja
	Eu desejo me cadastrar como usu�rio
	Para que eu possa realizar compras na loja


Cen�rio: Cadastro de usu�rio com sucesso
Dado Que o visitante est� acessando o site da loja
Quando Ele clicar em registrar
E Preencher os dados do formulario
	| Dados                |
	| Email                |
	| Senha                |
	| Confirma��o da Senha |
E Clicar no bot�o registrar
Ent�o Ele ser� redirecionado para a vitrine
E Uma sauda��o com seu e-mail ser� exibida no menu superior


Cen�rio: Cadastro com senha sem maiusculas
Dado Que o visitante est� acessando o site da loja
Quando Ele clicar em registrar
E Preencher os dados do formulario com uma senha sem maiusculas
		| Dados                |
		| E-mail               |
		| Senha                |
		| Confirma��o de senha |
E Clicar no bot�o registrar
Ent�o Ele receber� uma mensagem de erro que a senha precisa conter uma letra maiuscula

Cen�rio: Cadastro com senha sem caractere especial
Dado Que o visitante est� acessando o site da loja
Quando Ele clicar em registrar
E Preencher os dados do formulario com uma senha sem caractere especial
		| Dados                |
		| E-mail               |
		| Senha                |
		| Confirma��o de senha |
E Clicar no bot�o registrar
Ent�o Ele receber� uma mensagem de erro que a senha precisa conter um caractere especial