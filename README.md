Student-Management-System
A Windows Forms desktop application developed using C# and SQL Server to manage student records efficiently.
The application supports full CRUD operations (Create, Read, Update, Delete) with proper validation and database connectivity using ADO.NET.
Features

Add new student details

View student records in DataGridView

Update existing student information

Delete student records

Input validation for TextBoxes and ComboBoxes

Gender and Course selection using ComboBox (no manual typing)

Exception handling for database operations
Technologies Used

C#

Windows Forms

ADO.NET

 Database Structure
sql
CREATE TABLE StudentDataTable
(
    ID INT  PRIMARY KEY IDENTITY(1,1),
    FULL_NAME VARCHAR(100),
    AGE INT,
    GENDER VARCHAR(10),
    COURSE VARCHAR(50)
);

Project Experience
- Designed and developed a Student Management System using C# Windows Forms and SQL Server
- Implemented full CRUD operations using ADO.NET with parameterized SQL queries
- Worked with DataGridView to display, select, and edit student records
- Applied input validation techniques to ensure correct data entry
- Handled database and runtime errors using structured exception handling
- Gained practical experience in integrating UI controls with backend database logic.




DataGridView
