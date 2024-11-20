using NerdStore.BDD.Tests.Config;
using TechTalk.SpecFlow;

namespace NerdStore.BDD.Tests.Usuario
{
    [Binding]
    [CollectionDefinition(nameof(AutomacaoWebFixtureCollection))]
    public class Usuario_CadastroDeUsuarioSteps
    {
        private readonly AutomacaoWebTestsFixture _testsFixture;
        private readonly CadastroDeUsuarioTela _cadastroDeUsuarioTela;

        public Usuario_CadastroDeUsuarioSteps(AutomacaoWebTestsFixture testsFixture)
        {
            _testsFixture = testsFixture;
            _cadastroDeUsuarioTela = new CadastroDeUsuarioTela(_testsFixture.BrowserHelper);
        }

        [When(@"Ele clicar em registrar")]
        public void QuandoEleClicarEmRegistrar()
        {
            // Act
            _cadastroDeUsuarioTela.ClicarNoLinkRegistrar();

            // Assert
            Assert.Contains(_testsFixture.Configuration.RegisterUrl, _cadastroDeUsuarioTela.ObterUrl());
        }

        [When(@"Preencher os dados do formulario")]
        public void QuandoPreencherOsDadosDoFormulario(Table table)
        {
            // Arrange
            _testsFixture.GerarDadosUsuario();
            var usuario = _testsFixture.Usuario;

            // Act
            _cadastroDeUsuarioTela.PreencherFormularioRegistro(usuario);

            // Assert
            Assert.True(_cadastroDeUsuarioTela.ValidarPreenchimentoFormularioRegistro(usuario));
        }

        [When(@"Clicar no botão registrar")]
        public void QuandoClicarNoBotaoRegistrar()
        {
            _cadastroDeUsuarioTela.ClicarNoBotaoRegistrar();
        }

        [When(@"Preencher os dados do formulario com uma senha sem maiusculas")]
        public void QuandoPreencherOsDadosDoFormularioComUmaSenhaSemMaiusculas(Table table)
        {
            throw new PendingStepException();
        }

        [Then(@"Ele receberá uma mensagem de erro que a senha precisa conter uma letra maiuscula")]
        public void EntaoEleReceberaUmaMensagemDeErroQueASenhaPrecisaConterUmaLetraMaiuscula()
        {
            throw new PendingStepException();
        }

        [When(@"Preencher os dados do formulario com uma senha sem caractere especial")]
        public void QuandoPreencherOsDadosDoFormularioComUmaSenhaSemCaractereEspecial(Table table)
        {
            throw new PendingStepException();
        }

        [Then(@"Ele receberá uma mensagem de erro que a senha precisa conter um caractere especial")]
        public void EntaoEleReceberaUmaMensagemDeErroQueASenhaPrecisaConterUmCaractereEspecial()
        {
            throw new PendingStepException();
        }
    }
}
