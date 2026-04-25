# 🏦 Bank Management System

This is a **Bank Management System** built using C# and Entity Framework Core ⚙️ following a **Code First approach** 🧑‍💻. The project focuses on designing the database through code using EF Core, where models are defined in the application and then migrated to SQL Server using **Entity Framework Core Migrations** 📦.

The main goal of this project is to demonstrate how to build a clean and scalable backend system using **EF Core (EFC)** 🔄 while applying proper **Separation of Concerns** 🧩 to keep the code organized, maintainable, and easy to extend.

In this approach, the domain models are written first in C#, and EF Core is responsible for generating and updating the database schema through migrations 🗄️. This allows full control over the database structure directly from the codebase. Any changes in the models are tracked using migrations and applied to the database in a controlled way.

The project heavily uses **Entity Framework Core (EFC)** ⚙️ for data access, along with **LINQ** 📊 for querying and manipulating data in a clean and readable way. Migrations are a core part of the workflow, ensuring that the database stays in sync with the evolving domain models.

The project structure is organized as follows:

Bank-Management-System/

├── 📁 Models/            → Domain entities representing database tables  
├── 📁 Configurations/    → Fluent API configurations for relationships and constraints  
├── 📁 Enums/             → Strongly-typed values to improve readability and reduce magic values  
├── 📁 Helpers/           → Shared utility classes and reusable logic across the system  

This structure follows **Separation of Concerns** 🧠:
- 📦 Models define the domain structure  
- ⚙️ Configurations handle EF Core Fluent API mapping  
- 🔢 Enums provide clean and type-safe values  
- 🛠️ Helpers contain shared functionality and utilities  

By using a **Code First approach with EF Core** ✨, the project ensures that the database evolves with the application. Migrations make it easy to track changes, update schema versions, and maintain consistency between code and database.

Overall, this project demonstrates how to build a structured backend system using **Entity Framework Core + Code First + Migrations** 🚀 while maintaining clean architecture principles, proper layering, and scalable design.
