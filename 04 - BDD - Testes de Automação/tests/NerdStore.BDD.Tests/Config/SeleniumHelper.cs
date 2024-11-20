﻿namespace NerdStore.BDD.Tests.Config
{
    public class SeleniumHelper
    {

    }

    public class ConfigurationHelper
    {
        private readonly IConfiguration _config; // mesma das startup

        public ConfigurationHelper()
        {
            //DICA: Lembrar de ir na propriedade do arquivo json, alterar para a opção "Copy always"

            _config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
        }

        public string WebDrivers => $"{_config.GetSection("WebDrivers").Value}";
    }

    public enum Browser
    {
        Chrome,
        Firefox
    }

    public static class WebDriverFactory
    {
        public static IWebDriver CreateWebDriver(Browser browser, string caminhoDriver, bool headless)
        {
            IWebDriver webDriver = null;

            switch (browser)
            {
                case Browser.Firefox:
                    var optionsFireFox = new FirefoxOptions();
                    if (headless)
                        optionsFireFox.AddArgument("--headless");

                    webDriver = new FirefoxDriver(caminhoDriver, optionsFireFox);

                    break;
                case Browser.Chrome:
                    var options = new ChromeOptions();
                    if (headless)
                        options.AddArgument("--headless");

                    webDriver = new ChromeDriver(caminhoDriver, options);

                    break;
            }

            return webDriver;
        }
    }
}
