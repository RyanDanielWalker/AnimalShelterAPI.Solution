# _Animal Shelter API v 1.0_

#### _A C# web API for Cats and Dogs_

#### By _Ryan Walker_

## Description
An API that allows users to View, Add, Edit, and Delete cats and dogs from an imaginary Animal Shelter's archive. A user may interact with the in-use version of the API using Postman or the built-in Swagger UI. Additionally, users may download the corresponding Animal Shelter Client web application [here](https://github.com/RyanDanielWalker/AnimalShelterClient.Solution)

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

```
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server={YOUR_SERVER};Port={YOUR_PORT};database={YOUR_SCHEMA_NAME};uid=root;pwd={YOUR_PASSWORD};"
  }
}
```

   * Fill in the desired name of your server, port, schema and MySQL Workbench password, omitting the curly braces

### To run the API:
1. Navigate to `AnimalShelterAPI.Solution/AnimalShelterAPI` in your command line
2. Run the command `dotnet restore` to restore the dependencies that are listed in the .csproj
3. Run the command `dotnet build` to build the project and its dependencies into a set of binaries
4. Run the command `dotnet ef database update` to create database and populate tables
5. If you wish to update the database with any changes to the code, run the command `dotnet ef migrations add {MigrationName}` and  again `dotnet ef database update`
6. Finally, run the command `dotnet run` to run the project!
7. Note: `dotnet run` also restores and builds the project, so you can use this single command to start the app

## API Documentation
#### Client Application
1. Download the corresponding Animal Shelter API client web application [here](https://github.com/RyanDanielWalker/AnimalShelterClient.Solution)
#### Swagger
1. After launching the project with `dotnet run` gain access to the API with Swagger by visiting `localhost:5000/swagger`
#### Postman
1. Explore API endpoints using Postman
### API Endpoints
Request URL `https://localhost:5000`
### Cats
#### HTTP Request Structure for Cats
```
GET /api/cats
POST /api/cats
GET /api/cats/{id}
PUT /api/cats/{id}
DELETE /api/cats/{id}
```
#### Sample Request URL
```
https://localhost:5001/api/Cats?name=doug
```
#### Sample JSON Response for Cats
```
  { 
    "catId": 1,
    "name": "Doug",
    "age": 4,
    "gender": "Male",
    "description": "Lovely"
  }
```
### Dogs
#### HTTP Request Structure for Dogs
```
GET /api/dogs
POST /api/dogs
GET /api/dogs/{id}
PUT /api/dogs/{id}
DELETE /api/dogs/{id}
```
#### Sample Request URL
```
https://localhost:5001/api/Dogs?name=emma
```
#### Sample JSON Response for Dogs
```
  {
    "dogId": 5,
    "name": "Emma",
    "age": 18,
    "gender": "Female",
    "description": "Lovely"
  }
```
## Known Bugs
There were no bugs found

## Technologies Used
* ASP .NET Core MVC
* C#
* VS Code
* MySQL Workbench
* MySQL
* Entity Framework Core
* LINQ
* Swagger
* Swashbuckle.AspNetCore 
* Postman
* AspNetCore Mvc Versioning

### License

MIT

Copyright (c) 2021 _Ryan Walker_

## Contact Information
[Ryandanielwalker@gmail.com](mailto:ryandanielwalker@gmail.com)















