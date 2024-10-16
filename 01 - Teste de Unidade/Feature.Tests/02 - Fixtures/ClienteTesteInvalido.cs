using Feature.Clientes;

namespace Feature.Tests
{
    public class ClienteTesteInvalido
    {
        [Fact(DisplayName = "Novo Cliente Inválido")]
        [Trait("Categoria", "Cliente Fixture Testes")]
        public void Cliente_NovoCliente_DeveEstarInvalido()
        {
            // Arrange
            var cliente = new Cliente(
               Guid.NewGuid(),
               "",
               "",
               DateTime.Now,
               "edu2edu.com",
               true,
               DateTime.Now);

            // Act
            var result = cliente.EhValido();

            // Assert
            Assert.False(result);
            Assert.NotEqual(0, cliente.ValidationResult?.Errors.Count);
        }
    }
}
