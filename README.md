# _Animal Shelter API_

#### _A C# web API for Cats and Dogs_

#### By _Ryan Walker_

## Description
An API that allows users to View, Add, Edit, and Delete cats and dogs from an imaginary Animal Shelter's archive. A user may interact with the in-use version of the API using Postman or the built-in Swagger UI. 

## Setup and Use

### Prerequisites
* [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
* A text editor like [VS Code](https://code.visualstudio.com/)
* A command line interface like Terminal or GitBash to run and interact with the app.
* [MySQL Workbench](https://www.mysql.com/products/workbench/)
* (Optional)[Postman](https://www.postman.com/downloads/)

### Installation
1. Clone the repository: `$ git clone https://github.com/RyanDanielWalker/AnimalShelterAPI.Solution`
2. Navigate to the `AnimalShelterAPI.Solution/` directory on your computer
3. Open with your preferred text editor to view the code base

### Connecting project to database via appsettings.json
1. In the production folder `AnimalShelterAPI.Solution/AnimalShelterAPI` create a file called `appsettings.json`
2. Add the following code:
`{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database={YOUR_SCHEMA_NAME};uid=root;pwd={YOUR_PASSWORD};"
  }
}`
   * Fill in the desired name of your schema and your MySQL Workbench password, omitting the curly braces
3. Run the command `dotnet ef database update` to generate database using Entity Framework Core.
4. If you wish to update the database with any changes to the code, run the command `dotnet ef migrations add {MigrationName}` and again `dotnet ef database update`

4. To run the app:
    * Navigate to `AnimalShelterAPI.Solution/AnimalShelterAPI` in your command line
    * Run the command `dotnet restore` to restore the dependencies that are listed in the .csproj
    * Run the command `dotnet build` to build the project and its dependencies into a set of binaries
    * Run the command `dotnet ef database update` to create database and populate tables
    * Finally, run the command `dotnet run` to run the project!
    * Note: `dotnet run` also restores and builds the project, so you can use this single command to start the app
    * View the application via your preferred web browser by visiting `localhost:5000/`


