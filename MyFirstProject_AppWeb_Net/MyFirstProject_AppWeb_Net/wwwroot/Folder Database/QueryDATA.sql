--Mendapatkan semua data
USE db_test_crud;
SELECT * FROM Employees;
--Mendapatkan data tertentu
SELECT * FROM Employees
WHERE department = 'Research';

--Menambahkan data
INSERT INTO Employees (name, age, salary, department, sex)
VALUES('John Doe', 30, 5000, 'Research', 'M');
--Menambahkan data lebih banyak
INSERT INTO Employees (name, age, salary, department, sex)
VALUES
	('John Doe', 30, 5000, 'Research', 'M'),
	('Mike Ross', 27, 6000, 'Development', 'F'),
	('Sarah Lee', 25, 8000, 'HR', 'M');

--Mengubah data
UPDATE Employees
SET salary = 10000
WHERE id = 15;

--Menghapus data beberapa
--Menggunakan berdasarkan field id (unik)
DELETE FROM Employees WHERE id = 15;
--Menggunakan berdasarkan field tertentu (department)
DELETE FROM Employees WHERE department = 'Research';
--Menghapus semua data
DELETE FROM Employees;