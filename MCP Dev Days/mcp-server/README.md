# MCP Server

This project implements a basic MCP (Message Communication Protocol) server using C#. 

## Project Structure

- **src/**: Contains the source code for the MCP server.
  - **Program.cs**: Entry point of the application that initializes and starts the MCP server.
  - **Server.cs**: Defines the `Server` class which handles core functionality, including starting the server and processing messages.
  - **Models/**: Contains data models used in the application.
    - **Message.cs**: Represents the structure of messages exchanged in the MCP server.

- **MCPServer.sln**: Solution file that organizes the project files and configurations.

- **MCPServer.csproj**: Project file specifying dependencies, target framework, and build settings.

## Setup Instructions

1. Clone the repository:
   ```
   git clone <repository-url>
   ```

2. Navigate to the project directory:
   ```
   cd mcp-server
   ```

3. Restore the project dependencies:
   ```
   dotnet restore
   ```

4. Build the project:
   ```
   dotnet build
   ```

5. Run the server:
   ```
   dotnet run --project src/MCPServer.csproj
   ```

## Usage Guidelines

- The MCP server listens for incoming connections and processes messages according to the MCP protocol.
- Customize the `Server` class in `Server.cs` to modify server behavior or add new features.
- Use the `Message` class in `Models/Message.cs` to define the structure of messages exchanged between clients and the server. 

## Contributing

Feel free to submit issues or pull requests to improve the MCP server.