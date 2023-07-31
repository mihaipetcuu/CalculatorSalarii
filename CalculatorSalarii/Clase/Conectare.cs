using System.Configuration;

namespace CalculatorSalarii
{
    public class Conectare
    {
        public static string ConSir(string numeCon)
        {
            return ConfigurationManager.ConnectionStrings[numeCon].ConnectionString;
        }
    }
}
