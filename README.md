📘 School Management System (SMS)

A Complete C# WinForms + SQL Server Project

This repository contains the full implementation of the School Management System (SMS) project. It is built using C# WinForms, SQL Server, and a clean multi-layer architecture (Presentation → Business → Data Access).
The project manages all core operations of a school, including students, teachers, classes, subjects, exams, fees, and more.

📌 Table of Contents

Overview

Features

System Modules

Architecture

Database Structure

Screens Included

Technologies Used

How to Run

Project Files

Notes

🧭 Overview

The School Management System (SMS) is a desktop application that allows schools to manage:

Students

Teachers

Academic information

Fees and payments

Grades and report cards

User accounts and roles

It provides a complete real-world workflow for school administration.

⭐ Features
👨‍🎓 Student Management

Add / Edit / Delete student profiles

Student enrollment

Parent/guardian information

Student search and filtering

Student ID generation

👨‍🏫 Teacher Management

Add / Edit / Delete teachers

Assign teachers to subjects and classes

View teacher info

🏫 Class & Academic Management

Manage grades, classes, and sections

Assign students to classes

Assign subjects to classes

📚 Subjects

Add and manage subjects

Link subjects with teachers and classes

📝 Exams & Grades

Enter marks

Calculate totals/averages

Generate report cards

View student academic history

💰 Fees Management

Fee categories

Student fee payments

Payment history

Outstanding balance reports

🔐 Users & Login

Admin and normal user accounts

Permissions-based access

Secure login form

📊 Dashboard

Quick statistics

Total students, teachers, fees collected, etc.

📦 Other Utilities

Clean modular forms

Reusable user controls

Error handling & validators

SQL stored procedure support

🧱 Architecture
SMS Project
│
├── Presentation Layer (WinForms)
│   ├── Forms
│   ├── User Controls
│   └── UI Logic
│
├── Business Layer
│   ├── Business Rules
│   └── Data Validation
│
└── Data Access Layer
    ├── SQL Queries / Stored Procedures
    └── Database Connection Handling

🗄 Database Structure

Main tables include:

Students

Teachers

Classes

Sections

Subjects

StudentEnrollment

TeacherAssignments

Exams

Grades

Fees

Payments

Users

Roles

The database is designed with relationships, constraints, and normalization for consistency and performance.

🖼 Screens Included

Login Form

Dashboard

Manage Students

Manage Teachers

Manage Classes

Manage Subjects

Student Enrollment

Fees Management

Grades Entry

View Results / Reports

User Management

Settings

🛠 Technologies Used

C# WinForms (.NET Framework / .NET 6/7 depending on version)

SQL Server

ADO.NET / DAL

Object-Oriented Programming

Layered Architecture

▶️ How to Run

Restore the database (.bak file or SQL script).

Update the connection string in App.config.

Open solution in Visual Studio.

Build and run the project.

📁 Project Files

SMS.sln – Main solution

/Presentation – Forms + UI

/Business – Business logic

/DAL – Data Access Layer

/Database – SQL database backup

/Assets – Icons and resources

📝 Notes

This project is designed for learning and real-world application.
It demonstrates:

Clean WinForms development

Full CRUD operations

Multi-layer architecture

Real school workflows
