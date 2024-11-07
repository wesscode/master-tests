using Microsoft.AspNetCore.Mvc.Testing;
using NerdStore.WebApp.MVC;
using System.Text.RegularExpressions;

namespace NerdStore.WebApp.Tests.Config
{
    [CollectionDefinition(nameof(IntegrationWebTestsFixtureCollection))]
    public class IntegrationWebTestsFixtureCollection : ICollectionFixture<IntegrationTestsFixture<Program>> { }

    [CollectionDefinition(nameof(IntegrationApiTestsFixtureCollection))]
    public class IntegrationApiTestsFixtureCollection : ICollectionFixture<IntegrationTestsFixture<Program>> { }

    public class IntegrationTestsFixture<TProgram> : IDisposable where TProgram : class
    {
        public string AntiForgeryFieldName = "__RequestVerificationToken";

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

        public string ObterAntiForgeryToken(string htmlBody)
        {
            var requestVerificationTokenMatch =
               Regex.Match(htmlBody, $@"\<input name=""{AntiForgeryFieldName}"" type=""hidden"" value=""([^""]+)"" \/\>");

            if (requestVerificationTokenMatch.Success)
            {
                return requestVerificationTokenMatch.Groups[1].Captures[0].Value;
            }

            throw new ArgumentException($"Anti forgery token '{AntiForgeryFieldName}' não encontrado no HTML", nameof(htmlBody));
        }

        public void Dispose()
        {
            Client.Dispose();
            Factory.Dispose();
        }
    }
}
