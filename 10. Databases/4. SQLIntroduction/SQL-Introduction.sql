-- P04 Write a SQL query to find all information about all departments

SELECT
	*
FROM Departments

-- P05 Write a SQL query to find all department names.

SELECT
	Name
FROM Departments

-- P06 Write a SQL query to find the salary of each employee.

SELECT
	Salary
FROM Employees

-- P07 Write a SQL to find the full name of each employee.

SELECT
	FirstName + ' ' + MiddleName + ' ' + LastName
	AS FullName
FROM Employees

-- P08 Write a SQL query to find the email addresses of each employee.

SELECT
	FirstName + '.' + LastName + '@softuni.bg'
	AS [Full Email Addresses]
FROM Employees

-- P09 Write a SQL query to find all different employee salaries. 

SELECT DISTINCT
	Salary
FROM Employees

-- P10 Write a SQL query to find all information about the employees whose job title is “Sales Representative“.

SELECT
	*
FROM Employees
WHERE JobTitle = 'Sales Representative'

-- P11 Write a SQL query to find the names of all employees whose first name starts with "SA".

SELECT
	FirstName,
	MiddleName,
	LastName
FROM Employees
WHERE FirstName LIKE 'SA%'

-- P12 Write a SQL query to find the names of all employees whose last name contains "ei".

SELECT
	FirstName,
	MiddleName,
	LastName
FROM Employees
WHERE LastName LIKE '%ei%'

-- P13 Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].

SELECT
	Salary
FROM Employees
WHERE Salary BETWEEN 20000 AND 30000

-- P14 Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.

SELECT
	FirstName,
	MiddleName,
	LastName
FROM Employees
WHERE Salary IN (25000, 14000, 12500, 23600)

-- P15 Write a SQL query to find all employees that do not have manager.

SELECT
	*
FROM Employees
WHERE ManagerID IS NULL

-- P16 Write a SQL query to find all employees that have salary more than 50000. Order them in decreasing order by salary.

SELECT
	*
FROM Employees
WHERE Salary > 50000
ORDER BY Salary DESC

-- P17 Write a SQL query to find the top 5 best paid employees.

SELECT TOP 5
	*
FROM Employees
ORDER BY Salary DESC

-- P18 Write a SQL query to find all employees along with their address.

SELECT
	*
FROM Employees e
JOIN Addresses a
	ON a.AddressID = e.AddressID

-- P19 Write a SQL query to find all employees and their address.

SELECT
	*
FROM	Employees e,
		Addresses a
WHERE a.AddressID = e.AddressID

-- P20 Write a SQL query to find all employees along with their manager.

SELECT
	e.FirstName + ' ' +
	e.LastName AS Employee,
	em.FirstName + ' ' +
	em.LastName AS Manager
FROM Employees e
JOIN Employees em
	ON e.ManagerID = em.EmployeeID

-- P21 Write a SQL query to find all employees, along with their manager and their address.

SELECT
	e.FirstName + ' ' +
	e.LastName AS Employee,
	a.AddressText AS Address,
	em.FirstName + ' ' +
	em.LastName AS Manager
FROM Employees e
JOIN Employees em
	ON e.ManagerID = em.EmployeeID
JOIN Addresses a
	ON a.AddressID = e.AddressID

-- P22 Write a SQL query to find all departments and all town names as a single list.

SELECT
	Name
FROM Departments UNION SELECT
	Name
FROM Towns

-- P23 Write a SQL query to find all the employees and the manager for each of them along with 
-- the employees that do not have manager. 

SELECT
	e.FirstName,
	e.LastName,
	m.FirstName + ' ' + m.LastName AS [Manager Name]
FROM Employees e
LEFT OUTER JOIN Employees m
	ON e.ManagerID = m.EmployeeID

-- P24 Write a SQL query to find the names of all employees from the departments "Sales" and "Finance" 
-- whose hire year is between 1995 and 2005.

SELECT
	FirstName,
	MiddleName,
	LastName
FROM	Employees e,
		Departments d
WHERE YEAR(e.HireDate) BETWEEN 1995 AND 2005
AND d.Name = 'Sales'