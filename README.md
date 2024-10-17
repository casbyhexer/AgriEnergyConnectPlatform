Luwano Casby Mhango

Below is the link for Agri Energy Connect Platform

    "iisExpress": {
      "applicationUrl": "http://localhost:60667",
 
  "profiles": {
      "applicationUrl": "https://localhost:7012;http://localhost:5267",

      Agri-Energy Connect Platform User Manual
Table of Contents
Introduction
System Requirements
Installation
Configuration
Running the Application
User Roles and Permissions
Features and Usage
Farmer Features
Employee Features
Seeding Initial Data
Updating the Database
Troubleshooting

Introduction
The Agri-Energy Connect Platform aims to bridge the gap between South African suppliers of green energy technologies and the agricultural sector. The platform enables farmers to manage their products and employees to manage farmer profiles and view products.

System Requirements
.NET 6.0 SDK or later
SQLite database
Visual Studio 2019 or later / Visual Studio Code

Installation
Clone the Repository
Install Dependencies  
Build the Project
Open appsettings.json and configure the SQLite connection string
Ensure Migrations are Up to Date
Run the Application
Open a web browser and navigate to the link

User Roles and Permissions
Farmer: Can add products to their profile and view their own product listings.
Employee: Can add new farmer profiles, view all products from specific farmers, and use filters for product searching.

Features and Usage
Farmer Features:
Dashboard:
View your products.
Add new products.

Navigation:
Access via the "Farmers" section in the navigation menu.

Add Product:
Navigate to "Farmers > Add Product."
Fill in product details and click "Add Product."

Employee Features
Dashboard:
View all farmers and their products.
Add new farmer profiles.

Navigation:
Access via the "Employees" section in the navigation menu.
Add Farmer:
Navigate to "Employees > Add Farmer."
Fill in farmer details and click "Add Farmer."
View Farmer Products:
Navigate to "Employees > View Products."
Select a farmer to view their products.
Search Products:
Navigate to "Employees > Search Products."
Enter search criteria and click "Search."

Seeding Initial Data
Create the Data Initializer Interface and Implementation:
IDataInitializer.cs:
Register Data Initializer in Program.cs:
Updating the Database
Add Migration:
Update Database:

Troubleshooting
Missing DbSet Property:
Ensure that Farmers and Product classes are correctly defined and referenced in ApplicationDbContext.
Namespace Issues:
Verify that all necessary namespaces are included, especially when moving files or refactoring the project structure.
Migration Errors:
If migrations are not applied, check for errors in the migration files and ensure the database connection string is correctly configured.

This user manual provides a guide to setting up, configuring, and using the Agri-Energy Connect Platform, ensuring that both Farmers and Employees can effectively use the system's features.
