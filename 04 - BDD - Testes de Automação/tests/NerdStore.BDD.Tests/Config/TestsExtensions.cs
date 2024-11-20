
namespace NerdStore.BDD.Tests.Config
{
    public static class TestsExtensions
    {
        public static int ApenasNumeros(this string value)
        {
            return Convert.ToInt32(new string(value.Where(char.IsDigit).ToArray()));
        }
    }
}
