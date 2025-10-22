/* ==========================================================
   LABORATORIO #13 - Integración de SQL con C#
   Autor: Marcos Córdoba
   Base de Datos: Northwind
   ========================================================== */

USE Northwind;
GO

SELECT * FROM Products;
SELECT ProductID, ProductName, UnitPrice FROM Products;
SELECT ProductID, ProductName, UnitPrice FROM Products WHERE UnitPrice > 15;
SELECT ProductID, ProductName, UnitPrice FROM Products WHERE UnitPrice >= 15 AND UnitPrice <= 50;
SELECT ProductID, ProductName, UnitPrice FROM Products WHERE UnitPrice BETWEEN 15 AND 50;
SELECT ProductID, ProductName, UnitPrice FROM Products WHERE NOT UnitPrice > 15;
SELECT ProductID, ProductName, UnitPrice FROM Products WHERE ProductID > 25 OR UnitPrice < 10;

SELECT EmployeeID, LastName FROM Employees WHERE LastName LIKE 'D%';
SELECT EmployeeID, LastName FROM Employees WHERE LastName LIKE '%N';
SELECT EmployeeID, LastName, Title FROM Employees WHERE Title LIKE '%SALES%';
SELECT EmployeeID, LastName FROM Employees WHERE LastName NOT LIKE 'D%';
SELECT ProductID, ProductName, UnitPrice FROM Products ORDER BY ProductID ASC;
SELECT ProductID, ProductName, UnitPrice FROM Products ORDER BY ProductID DESC;
SELECT DISTINCT OrderID FROM [Order Details];
SELECT TOP 5 OrderID, ProductID, Quantity FROM [Order Details];
SELECT TOP 10 PERCENT OrderID, ProductID, Quantity FROM [Order Details];
SELECT CategoryName AS [Nombre de Categoría] FROM Categories;

SELECT OrderID, OrderDate, ShippedDate, ShippedDate - OrderDate AS [RetrasoEnvío] FROM Orders;

SELECT OD.OrderID, P.ProductID, P.ProductName
FROM Products P
INNER JOIN [Order Details] OD ON P.ProductID = OD.ProductID;

SELECT P.ProductName, S.CompanyName, S.ContactName
FROM Products P
FULL JOIN Suppliers S ON P.SupplierID = S.SupplierID;
