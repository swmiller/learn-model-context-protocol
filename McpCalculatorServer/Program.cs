using Microsoft.Extensions.DependencyInjection; // Imports dependency injection services.
using Microsoft.Extensions.Hosting;             // Imports hosting abstractions for building the app.
using Microsoft.Extensions.Logging;             // Imports logging interfaces.
using ModelContextProtocol.Server;              // Imports MCP server framework.
using System.ComponentModel;                    // Imports attributes like Description.

var builder = Host.CreateApplicationBuilder(args); // Creates a host builder with command-line args.
builder.Logging.AddConsole(consoleLogOptions =>   // Configures console logging:
{
    // Configure all logs to go to stderr
    consoleLogOptions.LogToStandardErrorThreshold = LogLevel.Trace; // All logs (Trace and above) go to stderr.
});

builder.Services
    .AddMcpServer()             // Adds MCP server services to the DI container.
    .WithStdioServerTransport() // Configures the server to use standard input/output for communication.
    .WithToolsFromAssembly();   // Registers tools (like CalculatorTool) from the current assembly.

await builder.Build().RunAsync(); // Builds and runs the host asynchronously.

[McpServerToolType] // Marks the class as an MCP server tool type.
public static class CalculatorTool
{
    [McpServerTool, Description("Adds two numbers")] // Marks the method as an MCP tool with a description.
    public static string Add(int a, int b) => $"Sum {a + b}"; // Adds two numbers and returns the result as a string.
}