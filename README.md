<!-- Change to Project Name -->
# _Best Restaurants in C#_

#### By _**Nick Sullivan**_

#### _A tracker for your favorite cuisines and restaurants._

## Technologies Used

* _C#_
* _.NET 5.0_
* _ASP.NET Core_
* _Bootstrap_
* _Razor View Engine_
* _Entity Framework_

## Description

_This application allows users to add different cuisine types to a database and then add various restaurants associated with a cuisine. Each restaurant may have attributes, such as average meal cost and location. The user may add, edit, delete, and view both restaurants and cuisine types. _

## Setup Instructions

* _Open your terminal and navigate to the folder you'd like to download the files into._
* _Run the command below_
> git clone https://github.com/nicholassull/best-restaurants-c-sharp.git
* _Using MySQL Workbench, import best_restaurants.sql to create a local instance of the database._
* Within the directory BestRestaurants, create a file named appsettings.json and input the lines of code bellow.
   * Replace [YOUR-PASSWORD] with the password you assign, and make sure the port and database name match your own.
> {
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=best_restaurants;uid=root;pwd=[YOUR-PASSWORD];"
  }
}

* _Navigate to BestRestaurants.Solution/BestRestaurants in your terminal._
* _Run the commands below_
>dotnet restore

>dotnet build

>dotnet run
* _Copy and paste the local host URL provided in the terminal into a web browser and enjoy!_

## Known Bugs

* _No known bugs at this time._

## License

Copyright (c) _03/10/2022_ _by Nick Sullivan_


_Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:_

_The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software._

_THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE._