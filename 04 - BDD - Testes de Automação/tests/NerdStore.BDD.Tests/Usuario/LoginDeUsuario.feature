Funcionalidade: Usu�rio - Login
	Como um usuario
	Eu desejo realizar o login
	Para que eu possa acessar as demais funcionalidades

Cen�rio: Relizar login com sucesso
Dado Que o visitante est� acessando o site da loja
Quando Ele clicar em login
E Preencher os dados do formulario de login
		| Dados                |
		| E-mail               |
		| Senha                |
E Clicar no bot�o login
Ent�o Ele ser� redirecionado para a vitrine
E Uma sauda��o com seu e-mail ser� exibida no menu superior
