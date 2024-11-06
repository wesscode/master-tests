using Microsoft.AspNetCore.Mvc.Testing;
using NerdStore.WebApp.MVC;
using NerdStore.WebApp.Tests.Config;

namespace NerdStore.WebApp.Tests
{
    [CollectionDefinition(nameof(IntegrationWebTestsFixtureCollection))]
    public class IntegrationWebTestsFixtureCollection : ICollectionFixture<IntegrationTestsFixture<Program>> { }

    [CollectionDefinition(nameof(IntegrationApiTestsFixtureCollection))]
    public class IntegrationApiTestsFixtureCollection : ICollectionFixture<IntegrationTestsFixture<Program>> { }

    public class IntegrationTestsFixture<TProgram> : IDisposable where TProgram : class
    {
        public readonly LojaAppFactory<TProgram> Factory;

        public HttpClient Client;

        public IntegrationTestsFixture()
        {
            var clientOptions = new WebApplicationFactoryClientOptions
            {

            };

            Factory = new LojaAppFactory<TProgram>();
            Client = Factory.CreateClient(clientOptions);
        }

        public void Dispose()
        {
            Client.Dispose();
            Factory.Dispose();
        }
    }
}
