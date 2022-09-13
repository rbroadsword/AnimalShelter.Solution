# Animal Shelter API

#### By: Ryan Broadsword

#### API for an animal shelter that lists and keeps track of cats and dogs.  

## Technologies Used

* C#
* .Net 5
* REPL
* CSS
* HTML
* SQL
* MySQL Workbench 
* Entity
* AspNet Core Web Api


## Description 

Animal Shelter: Create an API for a local animal shelter. The API will list the available cats and dogs at the shelter.

## Setup/Installation Requirements

### Clone project
* clone repository
* open in vs code
* open terminal
* in terminal run "dotnet build" to make sure everything is up to date.
* in terminal run "dotnet test" to see test results for functionality. 
* in termianl run "dotnet run" to run the program and follow the prompts given in the console. 
* select localhost:5000/ to launch application in browser.

### Create appsettings.json
* navigate to project folder in terminal "cd AnimalShelter"
* In termianl add "touch appsettings.json" 
* in the appsettings.json file add "{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=animal-shelter;uid=root;pwd=[YOUR PASSWORD HERE];"
  }
}
* add your password for SQL where it says pwd=[YOUR PASSWORD HERE] 


## Known Bugs



## License

Not currently licensed 

Copyright (c) September 10th 2022, by Ryan Broadsword rbroadsword@gmail.com 