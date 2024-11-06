using NerdStore.WebApp.MVC;
using NerdStore.WebApp.Tests.Config;

namespace NerdStore.WebApp.Tests
{
    public class UsuarioTests
    {
        private readonly IntegrationTestsFixture<Program> _testsFixture;

        public UsuarioTests(IntegrationTestsFixture<Program> testsFixture)
        {
            _testsFixture = testsFixture; 
        }
    }
}
