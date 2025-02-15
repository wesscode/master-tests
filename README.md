# Dominando Testes

## Testes de unidades
**- Frameworks**
  - MSTest
  - NUnit
  - XUnit
  - MOQ
  
**- Nomenclaturas:**
  - **Tipo 1**:
	  ObjetoEmTeste_MetodoComportamentoEmTeste_ComportamentoEsperado:
	    Ex: Pedido_AdicionarPedidoItem_DeveIncrementarUnidadesSeItemJaExistente
    	    Estoque_RetirarItem_DeveEnviarEmailSeAbaixoDe10Unidades

  - **Tipo 2**:
	  MetodoEmTeste_EstadoEmTeste_ComportamentoEsperado:
	    Ex: AdicionarPedidoItem_ItemExistenteCarrinho_DeveIncrementarUnidadesDoItem
	        RetirarItemEstoque_EstoqueAbaixoDe10Unidades_DeveEnviarEmailDeAviso

**- Ferramentas**
	- **Bogus**: Pacote para gerar dados humanos dinamicamente.
	- **AngleSharp**: Ler html e estrutura para que possamos realizar querys no html e encontre resultados com mais facilidade. 
  - **Mock**: Objetos mock ou objetos simulados, são objetos que simulam o comportamento de objetos reais de forma controlada.    
        	Uma vantagem do mock é que o objeto simulado pode ser criado dinamicamente através de um framework de Mock e poupando
        	o desenvolvedor ter que criar uma classe física para simular aquele objeto.
  - **AutoMock**: É uma feature que facilita a criação dos mocks.
  - **Fixture**: Quando queremos manter estado do nossos objetos para usa-los nos testes. Por default as classes são recriada sempre que cada método de teste é chamado, mesmo que a classe possua a criação do objeto no construtor.
                 Sendo assim a fixture cria os objetos antes de iniciar as classes de testes e só destrói os objetos depois da execução de todos métodos de testes.
  - **Fluent Assertions**: Pacote voltado para ter novas possibilidades de Asserts, além dos assert normais. Traz facilidades de implementar asserts além de trazer um código mais expressivos.

**Padrão AAA**
  - **Arrange**: Arrannjar, deixar o objeto pronto para a atuação.
	- **Act**: É método que estamos testando onde vamos analisar o comportamento dele.
	- **Assert**: Asserção, validar se os resultados gerados conferem com a intenção do teste.

**Organização**
	- Um projeto então somente um projeto de teste.

**Code Coverage**
  - Entender sobre porcentagem de cobertura de teste no seu código. Tendo como ideal entre 80 a 95% de cobertura de testes. Visual studio tem a possibilidade de analisar e te dar o resultado, e uma forma gratuita é usar o OpenCover.


 _- Executar os testes via linha de comando. É necessário o pacote xunit.runner.console e executar o comando dotnet vstest Features.Tests.dll_


  




## TDD
## Testes de integração
## BDD
## Testes automatizados
## Testes de Carga
## Testes de Performance
## Testes de Regressão
