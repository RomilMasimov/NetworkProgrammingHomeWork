using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostServer
{
    class Program
    {
        static void Main(string[] args) => MainAsync(args).GetAwaiter().GetResult();

        static async Task MainAsync(string[] args)
        {
            var connectionStr = ConfigurationManager.ConnectionStrings["LostDB"].ConnectionString;
            var server = new Server("http://localhost:27001/", connectionStr);
            await server.StartAsync();
        }
    }
}
