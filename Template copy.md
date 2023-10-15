# Overview

The **Inventory Management System** is a console-based C# application designed to assist users in managing and organizing an inventory of items. Its primary purpose is to provide a user-friendly interface for tasks such as adding, viewing, updating, and sorting items in an inventory. The system also offers search functionality to help users find specific items within the inventory.

## Purpose

The purpose of creating this software is to simplify inventory management for individuals or small businesses. It offers a straightforward and accessible way to keep track of items, their quantities, and prices. This can be particularly useful for small retailers, hobbyists, or anyone needing an efficient way to manage their inventory.

## Software Demo Video

To see a one-minute demonstration of the software in action and a walkthrough of the code, please check out the following YouTube video:

[Software Demo Video](https://youtu.be/VOVdqUNJaqI)

# Development Environment

The Inventory Management System was developed using the following tools and technologies:

- **Programming Language**: C#
- **Development Environment**: Visual Studio (or any C# development environment)
- **Libraries**: The software uses the .NET Framework and includes the System and LINQ libraries for various operations.

# Useful Websites

During the development of this project, the following websites were found helpful for reference, guidance, and troubleshooting:

* [Microsoft Docs for C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
  - The official documentation for the C# programming language, offering detailed information, code examples, and tutorials.

* [Stack Overflow](https://stackoverflow.com/)
  - A popular community-driven Q&A platform where developers can find solutions to common programming issues and get help with specific coding problems.

* [C# Station](http://csharp-station.com/)
  - C# Station provides a range of tutorials, articles, and resources for C# programming, suitable for beginners and experienced developers.

* [GitHub](https://github.com/)
  - GitHub serves as a valuable resource for version control, collaborative coding, and accessing open-source projects related to C# and .NET development.

These websites played a crucial role in the development process, aiding in problem-solving, learning, and optimizing the software's functionality.

# Inventory Management System

The **Inventory Management System** is a console-based C# application that allows users to manage an inventory of items. It provides various functions to add, view, update, delete, sort, and search for items in the inventory. Below is an overview of the functionality and features of the system:

## Main Menu
When you run the program, it displays a main menu with the following options:
1. **Add Item**: Allows you to add a new item to the inventory.
2. **View Inventory**: Displays the list of items in the inventory.
3. **Update Item**: Lets you update the details of an existing item.
4. **Delete Item**: Allows you to remove an item from the inventory.
5. **Sort Inventory**: Provides options to sort the inventory by name, quantity, or price.
6. **Search Inventory**: Lets you search for items by keyword.
7. **Exit**: Exits the program.

## Add Item
Selecting the "Add Item" option prompts you to enter details for a new item, including the name, quantity, and price. The item is then added to the inventory.

## View Inventory
Choosing the "View Inventory" option displays a list of all items in the inventory. If the inventory is empty, it will indicate that.

## Update Item
The "Update Item" option first displays the current inventory. You can select an item to update by specifying its index. You can then modify the name, quantity, and price of the selected item.

## Delete Item
Selecting "Delete Item" displays the current inventory. You can choose an item to delete by specifying its index. The selected item will be removed from the inventory.

## Sort Inventory
The "Sort Inventory" option allows you to sort the inventory based on your preference:
1. Sort by Name: Alphabetically sorts items by name.
2. Sort by Quantity: Sorts items by quantity in ascending order.
3. Sort by Price: Sorts items by price in ascending order.

The sorted inventory is then displayed.

## Search Inventory
Choosing "Search Inventory" prompts you to enter a keyword. The system will search for items in the inventory whose names contain the specified keyword (case-insensitive). It then displays the search results.

## Input Validation
The system provides input validation to ensure that you enter valid integer and decimal values where required. If invalid input is provided, it prompts you to try again.

## Exiting the Program
You can exit the program at any time by selecting "Exit" from the main menu.

This Inventory Management System is a basic console-based application that provides essential inventory management functions. Users can interact with it to maintain a list of items, update their details, sort the inventory, and search for specific items. It's a simple yet functional tool for managing inventory.
