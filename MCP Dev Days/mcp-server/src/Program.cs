using System;
using System.Threading.Tasks;


namespace MCPServer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var server = new Server(8180);
            await server.StartAsync();
            Console.WriteLine("MCP Server is running. Press Enter to exit...");
            Console.ReadLine();
        }
    }
}