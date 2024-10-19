namespace Features.Tests
{
    // Exemplo quando queremos PULAR um testes.
    public class TesteNaoPassandoMotivoEspecifico
    {
        [Fact(DisplayName = "Novo Cliente 2.0", Skip ="Nova versão 2.0 quebrando")]
        [Trait("Categoria", "Escapando dos Testes")]
        public void Teste_NaoPassando_VersaoNovaNaoCompativel()
        {
            Assert.True(false);
        }
    }
}
