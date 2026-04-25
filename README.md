# 🏦 Bank Management System

This is a **Bank Management System** built using C# and Entity Framework Core ⚙️ with a **Database First approach** 🗄️. The project demonstrates how to work with an existing SQL Server database where EF Core is used to scaffold the DbContext and models directly from the database. It focuses on using **Entity Framework Core (EFC)** for data access, **LINQ** for querying 📊, and handling schema changes when needed during development.

The main idea behind this project is to apply **Separation of Concerns** 🧩 while working with a database-driven architecture. Instead of mixing everything together, the system is divided into clear parts so each responsibility is isolated, easier to understand, and easier to maintain.

Entity Framework Core is the main ORM used to communicate with the database 🔄. Since this is a Database First approach, the database is created first 🗄️, and EF Core is used to scaffold the models and DbContext from it. Any changes in the database are reflected back into the application by updating the generated models. Migrations can also be used in some development cases when extending the schema, but the database remains the source of truth 📌.

The project structure is organized as follows:

Bank-Management-System/
│
├── 📁 Models/            → Entity classes generated from the database and used by EF Core  
├── 📁 Configurations/    → Fluent API configurations for mapping tables and relationships  
├── 📁 Enums/             → Enumeration types for cleaner and more readable code  
├── 📁 Helpers/           → Utility and reusable logic used across the system  

This structure strongly supports **Separation of Concerns** 🧠.  
- 📦 Models represent database tables  
- ⚙️ Configurations define entity mapping using Fluent API  
- 🔢 Enums replace magic strings/numbers with strongly typed values  
- 🛠️ Helpers contain shared reusable functionality  

By using Entity Framework Core with a Database First approach, the project stays clean, maintainable, and closer to real-world enterprise systems 🏢. It shows how database-driven applications can still follow clean architecture principles and remain scalable without becoming tightly coupled.

Overall, this project demonstrates how to build a structured backend system using EF Core with Database First design 📊, while applying proper layering, clean code principles ✨, and separation of responsibilities.
