Project Description
This is a simple console-based Shopping Cart System created using C#.
It allows users to choose products, enter quantity, and simulate a shopping process.

The system also checks stock availability, validates input, and computes the total with discount.

Products
Watermelon
Peach
Melon

 Features
Display store menu
Accept user input (product and quantity)
Input validation using int.TryParse()
Check stock availability
Prevent buying more than available stock
Handle out-of-stock products
Add items to cart
Deduct stock after purchase
Display receipt
Compute total and final total
Apply 10% discount if total is 5000 or more
Support multiple customers
Show updated stock after checkout

How to Run
Open the project in Visual Studio
Run the program
Follow the instructions:
Enter product number
Enter quantity
Choose to add more items or not

AI Usage in This Project
Where AI was used

AI was used to help with:

Understanding the structure of the program
Writing the Product class and methods
Input validation using int.TryParse
Creating the flowchart
Why AI was used

AI was used to:

Better understand C# concepts
Fix errors and improve the logic
Make the code simpler and easier to follow
Example prompts
"How to create a simple shopping cart in C#?"
"How to validate user input in C#?"
"How to apply discount if total is 5000 or more?"
Changes made
Simplified the code structure
Adjusted logic to match the requirements
Improved variable names and readability



-------------------- Updated README.md-------------------

Project Overview
This project is an enhanced console-based Shopping Cart System developed in C# using object-oriented programming principles.
It allows users to browse products, manage a shopping cart, perform checkout with payment validation, generate receipts, and track order history during runtime.
The system also includes stock management, low-stock alerts, product search, and category filtering.

Features
Product Management
Display product list using arrays
Each product includes:
ID
Name
Category
Price
Stock
Stock tracking and updates after purchase

Search & Filter
Search products by name
Filter products by category:
Food
Electronics
Clothing

Cart Management System
Users can:
Add products to cart
View cart items
Update item quantity
Remove items
Clear cart
Prevent duplicate cart entries (updates quantity instead)
 Checkout System
Computes total price of cart
Applies 10% discount if total ≥ 5000
Validates payment input
Ensures payment is sufficient
Calculates change automatically

 Receipt System
Each checkout generates:
Receipt Number (e.g., 0001)
Date and Time of purchase
List of purchased items
Grand total
Discount applied
Final total
Payment amount
Change

 Stock Management
Deducts stock after successful checkout
Prevents purchasing out-of-stock items
Displays low stock alerts (≤5 items remaining)

 Order History
Stores completed transactions using arrays
Displays:
Receipt number
Final total
History is retained during program execution

 Input Validation
Uses int.TryParse() and double.TryParse()
Prevents invalid numeric inputs
Ensures valid menu selection
Strict Y/N input validation (re-prompts until correct)

Technologies Used
C#
.NET Console Application

AI USAGE IN THIS PROJECT

AI was used as a development assistant and learning tool to help improve logic structure, debugging, and system design.

Areas where AI was used:
Designing cart management system using arrays
Implementing duplicate cart handling logic
Creating stock validation and deduction system
Building checkout payment validation loop
Generating receipt format with date/time and receipt number
Designing order history storage system
Improving input validation using TryParse methods
Example prompts used:
"How do I implement a cart system using arrays in C#?"
"How can I prevent duplicate items in a shopping cart?"
"How do I validate payment and compute change in C#?"
"How do I generate a receipt number like 0001?"
"How do I store order history using arrays?"
Improvements made after AI suggestions:
Converted List-based structure into array-based system (requirement compliance)
Improved cart logic to update existing items instead of duplicating
Enhanced validation for all user inputs
Added structured receipt generation system
Implemented low stock alert feature
Improved code readability and modular design



