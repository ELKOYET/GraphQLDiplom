using Microsoft.Extensions.DependencyInjection;
using System;
using GraphQlDiplom;
using System.Threading.Tasks;

namespace ForTestGraph
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IServiceCollection services = new ServiceCollection();
            services.AddGraphqlClient().ConfigureHttpClient(client => client.BaseAddress = new Uri("https://localhost:44308/graphql/"));
            IServiceProvider serviceProvider = services.BuildServiceProvider();
            IGraphqlClient client = serviceProvider.GetRequiredService<IGraphqlClient>();
            var result = await client.GetAllClients.ExecuteAsync();
           
                Console.WriteLine(result.Data.ReadClients.Count);


           
            Console.ReadKey();

        }
    }
}
