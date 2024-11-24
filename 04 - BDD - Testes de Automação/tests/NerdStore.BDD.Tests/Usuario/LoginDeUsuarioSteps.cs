using System;
using TechTalk.SpecFlow;

namespace NerdStore.BDD.Tests.Usuario
{
    [Binding]
    public class LoginDeUsuarioSteps
    {
        [When(@"Ele clicar em login")]
        public void QuandoEleClicarEmLogin()
        {
            throw new PendingStepException();
        }

        [When(@"Preencher os dados do formulario de login")]
        public void QuandoPreencherOsDadosDoFormularioDeLogin(Table table)
        {
            throw new PendingStepException();
        }

        [When(@"Clicar no botão login")]
        public void QuandoClicarNoBotaoLogin()
        {
            throw new PendingStepException();
        }
    }
}
