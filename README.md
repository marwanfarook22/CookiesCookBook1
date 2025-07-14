 # Cookies Cookbook 🥐

A delicious C# application for managing and exploring cookie recipes, refactored with LINQ for cleaner and more efficient code! 🍪

![Build Status](https://img.shields.io/badge/build-passing-brightgreen)
![License](https://img.shields.io/badge/license-MIT-blue)

## Table of Contents
- [Introduction](#introduction)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Refactoring to LINQ](#refactoring-to-linq)
- [Contributing](#contributing)
- [License](#license)

## Introduction
The **Cookies Cookbook** is a C# project developed as part of the *Ultimate C# Masterclass* assignment. This project originally used traditional loops to manage cookie recipes but has been refactored to leverage LINQ for more concise, readable, and efficient code. Whether you're a beginner learning LINQ or a developer looking to explore recipe management, this project is a sweet way to dive into C# programming! ✨

 

## Features
- 🍪 Manage a collection of cookie recipes
- ✅ Filter and query recipes using LINQ
- 🔍 Search recipes by ingredients or categories
- 📋 Display recipe details in a clean format
- 🛠️ Refactored from loops to LINQ for improved readability and performance

## Installation
To get started with the Cookies Cookbook, follow these steps:

1. **Clone the repository**:
   ```bash
   git clone https://github.com/username/cookies-cookbook.git
   ```
2. **Navigate to the project directory**:
   ```bash
   cd cookies-cookbook
   ```
3. **Restore dependencies**:
   Ensure you have the .NET SDK installed, then run:
   ```bash
   dotnet restore
   ```
4. **Build the project**:
   ```bash
   dotnet build
   ```

**Prerequisites**:
- .NET SDK (version 6.0 or higher)
- A C# IDE (e.g., Visual Studio, VS Code, or Rider)

## Usage
Run the application to explore cookie recipes:
```bash
dotnet run
```

Example usage:
- List all recipes with a specific ingredient using LINQ queries.
- Filter recipes by category (e.g., "Chocolate", "Vegan").
- Add or modify recipes and see the results instantly.

For detailed code examples, check the [source code](src/) or the [Refactoring to LINQ](#refactoring-to-linq) section below.

## Refactoring to LINQ
This project is part of the *Ultimate C# Masterclass* assignment focused on refactoring traditional loop-based code into LINQ queries. The goal is to make the code more concise, maintainable, and expressive.

### Example Refactoring
**Before (using loops)**:
```csharp
var chocolateRecipes = new List<Recipe>();
foreach (var recipe in recipes)
{
    if (recipe.Ingredients.Contains("Chocolate"))
    {
        chocolateRecipes.Add(recipe);
    }
}
```

**After (using LINQ)**:
```csharp
var chocolateRecipes = recipes.Where(r => r.Ingredients.Contains("Chocolate")).ToList();
```

### Assignment Details
- **Objective**: Refactor loop-based methods in the Cookies Cookbook to use LINQ methods like `Select`, `Where`, `OrderBy`, etc.
- **Source Code**: The original code can be found in the course’s Git repository or in the attachment to the “Assignment - Refactoring to LINQ - Description and requirements” lecture.
- **Validation**: After refactoring, the program has been tested to ensure it still functions correctly, maintaining the same output as the original loop-based code.

Check the [src/](src/) directory for refactored code examples and comments explaining the LINQ transformations.

## Contributing
We welcome contributions to make the Cookies Cookbook even tastier! 🍰 To contribute:
1. Fork the repository.
2. Create a new branch (`git checkout -b feature/your-feature`).
3. Make your changes and commit (`git commit -m "Add your feature"`).
4. Push to your branch (`git push origin feature/your-feature`).
5. Open a pull request.

 

Have questions or suggestions ? Open an [issue]( src/[https://github.com/username/cookies-cookbook/issues](https://github.com/marwanfarook22/CookiesCookBook1/issues)) or reach out on [Linked_in]( src/[https://x.com/yourusername](https://www.linkedin.com/in/marwan-farook-411154314/)).

 
