using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;


namespace MlStart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fileName = "MLstartConfig.json";
            var content = @"{""Test"": ""123""}";
            File.WriteAllText(fileName, content);

            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory
                .GetCurrentDirectory())
                .AddJsonFile(fileName).Build();

            string testConfig = configuration["Test"];
            Console.WriteLine(testConfig);
        }
    }
}
