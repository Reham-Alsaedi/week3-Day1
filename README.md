Employee Management Application

This project allows users to manage employee records with basic CRUD (Create, Read, Update, Delete) operations.

1. Create the Model (Employee.cs)
2. 
Define the Employee class with the following properties:
Id (int, primary key)
Name (string)
Position (string)
Salary (decimal)

3. Create the Database Context (AppDbContext.cs)

Configure Entity Framework Core to enable database access.
Add DbSet<Employee> in AppDbContext.

4. Modify the Controller (EmployeeController.cs) 
Implement CRUD methods for:
Index: List all employees.
Create: Add a new employee.
Edit: Modify an existing employee.
Delete: Remove an employee.
Use dependency injection for accessing the database.

6. Create a View to List Employees 
Implement Index.cshtml to display a list of employees.

8. Create a View to Add New Employees 
Implement Create.cshtml with a form for adding new employees.

10. Create a View to Edit Employee Details
Implement Edit.cshtml with a form for editing employee details.

12. Create a View to Confirm Deletion
Implement Delete.cshtml to confirm before removing an employee.

