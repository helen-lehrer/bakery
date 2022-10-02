# Pierre's Bakery

#### A C# Console Application for a Bakery

#### By Helen Lehrer

## Description

 A bakery console application where the user receives the following:

* A prompt with a welcome message
* The cost of `Bread`
* The cost of `Pastries`
* Current discount deals

The current deals are:

* `Bread`: Buy 2, get 1 free (every 3rd loaf of bread is free.). A single loaf costs $5, two loaves costs $10, and three loaves cost $10.
* `Pastry`: Buy 1 for $2, 3 for $5, 4 for $7, 4 for $9, and 6 for $10.

The user will be prompted to input the number of loaves and pastries they would like to order. The application will calculate the total price of each item and the total order based on the current deals and display it to the user.

## Technologies Used

* .NET 5.0.401
* C#
* Git Bash
* MSTest

All functionality for the models are tested. The code uses custom classes, namespaces, autoimplemented properties, and class methods.

## Setup/Installation Requirements

Enter this command into your terminal to clone the project: 
```bash
$ git clone https://github.com/helen-lehrer/bakery/
```

Navigate from the root directory of the repo into the folder `Bakery`:
```bash
$ cd Bakery
```

Compile the code: 
```bash
$ dotnet build
```

---

#### Follow these instructions in your command line to set up **MSTest**:

Navigate from the root directory of the repo to folder `Bakery.Tests`: 
```bash
$ cd Bakery.Tests
```

Download & install **MSTest**: 
```bash
$ dotnet restore
```

To run **MSTest**, type this into your command line while you are inside of the Bakery.Tests folder: 
```bash
$ dotnet test
```

---

#### To run the application: 

Navigate from the root directory of the repo into the folder `Bakery`:
```bash
$ cd Bakery
```

Run the application:
```bash
$ dotnet run
```

## Known Bugs

* None

## License
[![License](https://img.shields.io/badge/License-BSD_3--Clause-blue.svg)](https://opensource.org/licenses/BSD-3-Clause)

&copy; _Copyright 2022 Helen Lehrer_

