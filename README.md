# Local Business Api

### By Michael Carroll

## Description

An Api that will return local businesses in the database. The businesses will return with the following information:
* Business Name
* Business Type
* Business Description
* Business Reviews

## Technologies User

* C#
* .NET
* .ASP.NET CORE
* MVC
* Entity Framework Core
* EF Core Migrations
* Swashbuckle
* Swagger
* MySQL


## Instructions to set up database
1. Clone this repo.
2. Open your terminal and navigate to this project's directory called "LocalBusinessApi".
3. Create a file called 'appsettings.json' in LocalBsinesssApi production directory and add the following code:
  ```
  {
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=local_business_api;uid=[YOUR_SQL_USER_ID];pwd=[YOUR_SQL_PASSWORD];"
    }
  }
  ```
  * Make sure to plug in your SQL user id and password at ```[YOUR_SQL_USER_ID]``` and ```[YOUR_SQL_PASSWORD]```
4. Set up the database:
  * Make sure EF Core Migrations is installed on your computer by running ```dotnet tool install --global dotnet-ef --version 6.0.0```
  * In the production folder of the project run:
  ```
  dotnet ef database update
  ```
  * You should see the new schema in your MySql Workbench called ```local_business_api```


## Testing the API Endpoints



### Available Endpoints

```

GET: https://localhost:5001/api/Businesses/
GET: https://localhost:5001/api/Businesses/{id}
POST: http://localhost:5001/api/Businesses/
PUT: https://localhost:5001/api/Businesses/{id}
DELETE: https://localhost:5001/api/Businesses{id}

```

# To test routes in Swagger: 

* In your terminal, navigate to the project directory and run ```dotnet watch run``` 
* Your browser will open https://localhost:5001/swagger/index.html
* All endpoints will be available within swagger giving the user full CRUD capability.


## Known bugs

## License

MIT License

Copyright (c) 2023 Michael Carroll

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.