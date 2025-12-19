Student-Management-System

A Windows Forms desktop application developed using C# and SQL Server to manage student records efficiently.
The application supports full CRUD operations (Create, Read, Update, Delete) with proper validation and database connectivity using ADO.NET.
Features

1. Add new student details

2. View student records in DataGridView

3. Update existing student information

4. Delete student records

5. Input validation for TextBoxes and ComboBoxes

6. Gender and Course selection using ComboBox (no manual typing)

7. Exception handling for database operations

Technologies Used

1. C#

2. Windows Forms

3. ADO.NET

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




