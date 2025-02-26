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

## TDD:
Unidade com ou sem TDD: Valida o funcionamento da unidade implementada.
TDD: Técnica de desenvolvimento para sempre garantir que um código já nasça testado.
- Aplicar técnica baby steps
- Passos: Red, Green e refactory

## Testes de integração:
Integração: Valida o funcionamento do código de ponta a ponta exceto a TELA, testa o backend e suas integrações, falando diretamente com o controller. Aplicáveis mais para API, devido aplicações MVC serem complexas de testas com integração, sendo mais indicado testes automatizados.


## Teste de carga:
Carga: Valida e cria métricas da capacidade do seu app

## BDD (Desenvolvimento guiado por comportamentos)
- Voltado mais para testar o que o software se propõe a fazer.
- Processo onde busca envolver as pessoas de fora para dentro, desde o cliente que pediu o app ou membros da equipe.
- Escrever histórias para apresentar a necessidade de um usuários e explicar as funcionalidades da aplicação.
- Desenvolver app guiado por cenários de testes dos comportamentos descritos na história do usuário.
- Escrever testes de integração ou automação para validar os comportamentos como a uma bateria de testes de regressão.
- Ciclo BDD:
	História que precisa ser implementado => Escrever um cenário que falhe => Codificar => Aplicar o TDD(RED,GREEN,REFACTORY) => Cenários passando => Refatoração(comportamento está sendo atendido? o código está sendo atendido ?)

* BDD != TDD
- BDD: É sobre a aplicação atender, validar o comportamento, regra de negócio, especificações, necessidades do cliente.
- TDD: Guiar o desenvolvedor através dos testes, para escrever um código de qualidade e testável, para obter todos os benefícios de um código de qualidade.
- DDD: Desenvolvimento guiado pelo o Domínio

**Escrevendo User history**
* Contexto da funcionalidade:
Como um <papel do negocio> (usuário, gerente, cliente) => As a
Eu quero <objetivo do negócio> (o que o app vai fazer) => I want to
Para <Beneficio/Resultado obtido> => So that

**Cenários:**
Cenário 1: Cenário que a operação dá certo.

DADO que o cenário possui um contexto especifico
E um outro detalhe adicional
QUANDO o usuário realizar tal ação
ENTÃO alguma coisa que dará certo acontecerá

**Ferramenta para BDD**
- SpecFlow(Versão do cucumber para .NET)

Transforma texto em ações e compatível com todas as versões do VS atuais.

- Instalação do SpecFlow:
Install-Package SpecFlow

- Instalação para reconhecimento do Visual Studio com XUnit
Install-Package SpecFlow.xUnit

- Para ajudar em cenários que possuem teste de integração e automação com msbuild
Install-Package SpecFlow.Tools.MsBuild.Generation

## Testes automatizados
Automatizados: Valida entradas pela a TELA, usadas mais para testar Aplicações MVC, por ser mais simples e além de pegar tela, pega tbm todo o fluxo do backend.

- Utilização do Selenium
- Padrão Page Object Model
- Teste de aceitação/regressão com SpecFlow
- Boas práticas no design dos testes

* Selenium:
- Realizar automação de ações para browsers
- Utilizado para automação de teste e Web Crawling
- Compatível com Visual Studio
- Rodando teste com azureDevOps: https://learn.microsoft.com/en-us/azure/devops/pipelines/test/continuous-test-selenium?view=azure-devops
- No fim podemos compilar um entregável de testes e executar o comando: dotnet vstest NerdStore.BDD.Tests.dll 

**Pacotes:**
Install-Package Selenium.WebDriver
Install-Package Selenium.Support
Install-Package DotNetSeleniumExtras.WaitHelpers

**WebDriver Google:**
https://chromedriver.chromium.org/downloads

_para usar o selenium para nossos projetos precisamos, instalar os pacotes no app e 
baixar o webdriver do browser espefico que deseja trabalhar com mesma do seu browser instalado._

**Estrutura POM(Page Object Model)**

- Padrão de projeto descrito por Martin Fowler
- Diz como criar um repositório de objetos com elementos contidos numa página Web. Sob este modelo, para cada página, deve haver uma classe correspondente.
- Benefícios:
	- Reaproveitamento de código
	- Código mais limpo
	- Facilidade na manutenção
	- Maior independência dos testes como uma bateria de testes de regressão.

POM => Repositório de métodos possíveis para uma tela.

## Testes de Carga
- Teste de desempenho/performance: Garantir que sua aplicação responda bem a um 	número de conexões esperadas. Neste tipo de teste a preocupação é realizar uma 	"regressão" para garantir que a aplicação não perdeu desempenho após uma mudança e 	que ela vai conseguir atender a demanda esperada com um tempo de resposta 	satisfatório. Ex. Menos de 500ms para o "response time".

- Teste de carga: Quantas transações serão suportadas se o número de usuários aumentar em 50%? O Objetivo principal é encontrar o limite da capacidade da aplicação e identificar qual o gargalo(banco de dados, hardware, cache). Não é o objetivo do teste de carga encontrar problemas funcionais na aplicação. É o tipo de teste que precisa ser feito se a aplicação possui picos sazonais onde o aumento de usuários é expressivo.(ex. promoções, natal, black-friday). É utilizado também para validar se uma implementação de performance produziu resultados ao comparar um resultado anterior dos testes com a atual após a implementação. Pode ser utilizado para validar se a escala automática(horizontal) está funcionando corretamente no tempo esperado.

- Teste de Stress: Como a aplicação irá se comporta se um número não previsto de requisições for disparado simultaneamente ? O teste é baseado no disparo de massivas quantidades de requests simultâneos durante alguns minutos. O objetivo é entender o comportamento da aplicação neste tipo de cenário. O que se espera é entender que tipo de "crash" a aplicação pode apresentar, qual o tempo de recuperação da aplicação após uma onda massiva de requests e se a aplicação retornar o estado normal se algum tipo de intervenção manual. É utilizado também para validação de cenários de "disaster recovery". No caso de clister é desligado um nó ou mais para analisar o comportamento esperado e a recuperação. Muitas vezes o teste é  disparado contra uma funcionalidade específica para entender como o resto da aplicação é afetada.

- Ferramentas de mercado: 
	- Apache JMeter(funciona local e é opensource)
	- BlazeMeter(Web pago)
	- Artillery.io(indicado para app rest api backend, gratuito)
	
- APDEX - Índice de satisfação(Aplication Performance Index): É um "score" que vai apontar a classificação de satisfação do cliente com base nos resultados de milhares de requests, considerando os requests com melhor tempo de resposta e os demais dentro do limite tolerável. Metrica global, onde podemos definir para uma funcionalidade, para um departamento para o app inteiro.
	
- Como realizar um teste de carga
download e instalação o java
download do jmeter
criar plano de testes
ou podemos criar com BlazeMeter para gravar nosso teste e gerar o arquivo de plano de teste e excuta-lo no JMeter


## Testes de Regressão
Regressão: Valida se o app não deixou de fazer o que ela já fazia antes.

## Testes de Aceitação
Aceitação: Quando vc testa funcionalidade e testa mostrando o cliente se a história bate com o que de fato ele pediu.