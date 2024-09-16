# FizzBuzz

This FizzBuzz application built with ASP.NET Core that processes an array of values and returns specific output based in FizzBuzz rules.

## Features

- Accept an array of values.
- Outputs "Fizz" for multiple of 3.
- Outputs "Bizz" for multiple of 5.
- Outputs "FizzBuzz" for multiple of 3 and 5.
- Output each division performed for non-multiple of 3 and 5.
- Handles invalid values.

## Project Structure

- Models: Contains the `FizzBuzzModel`
- Interfaces: Contains the `IFizzBuzzService` interface.
- Services: Contains the `FizzBuzzService` class which processes the values.
- Factories: Contains the `FizzBuzzServicefactory` class which create the instances of `FizzBuzzService`.
- Controllers: Contains `FizzBuzzController` class which handles the API requests.
- Tests: Contains Unit tests for the FizzBuzzService using xunit.
  
## Getting Started

## Prerequisites

- .Net 8 SDK
- Visual Studio 2022 / Visual Studio Code

## Installation

- Clone the repository

`git clone https://github.com/aftabphb043/FizzBuzz.git
cd FizzBuzz`

- Restore dependencies

`dotnet restore`

## Running the application

- Build the project

`dotnet build`

- Run the application

`dotnet run`

## Navigate to swagger UI

- Open the browser and Navigate to `https://localhost:<port>/swagger` to interact with the API.
  
## Running the Tests

- Navigate to the test project directory

`cd FizzBuzz.Tests`

- Run the tests

`dotnet test`

## API Usage

## EndPoint

- POST/FizzBuzz

## Request Body

- JSON

`
{
    "Values": ["1","3","5","","15","A","23"]
}
`

## Response

-JSON

`
[
    "Divided 1 by 3\nDivided 1 by 5",
    "Fizz",
    "Buzz",
    "Invalid item",
    "FizzBuzz",
    "Invalid item",
    "Divided 23 by 3\n Divided 23  by 5"
]
`
