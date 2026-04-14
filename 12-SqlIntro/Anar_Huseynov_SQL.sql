create database Company

use Company

create table Employees(
	  EmployeeID int,
	  FirstName nvarchar(50),
	  LastName nvarchar(50),
	  Email nvarchar(70),
	  PhoneNumber nvarchar(20),
	  HireDate date,
	  JobTitle nvarchar(50),
	  Salary decimal(10,2),
	  Department nvarchar(50)
);

insert into Employees values 
(1,'Anar', 'Huseynov', 'anar@gmail.com', '0555141554', '2021-04-18', 'Backend Developer', 4700,'IT'),
(2,'Huseyn', 'Rzayev', 'huseyn@gmail.com', '0516310245', '2020-10-26', 'Chief Accountant', 5000,'Finance'),
(3,'Mehdi', 'Qurbanov', 'mehdi@gmail.com', '0554452077', '2024-05-12', 'HR Manager', 1500,'HR'),
(4,'Hesen', 'Aghaverdiyev', 'hesen@gmail.com', '0707105383', '2019-02-06', 'Software Engineer', 4800,'IT'),
(5,'Ehmedaga', 'Ehmedov', 'ehmed@gmail.com', '0773219551', '2025-07-14', 'Sales Manager', 1200,'Sales & Customer Service');

insert into Employees values
(6,'Leyla', 'Hesenova', 'leyla@company.az', '0771234567', '2015-03-09', 'Project Manager', 2400, 'Management')

insert into Employees values
(7,'Huseyn', 'Agharzayev', 'huseyn@email.com','0553428976', '2018-11-29', 'Accountant', 1400,'Finance')
--SELECT Query-lər:
select * from Employees
select * from Employees where Salary>2000
select * from Employees where Department='IT'
select * from Employees order by Salary desc
select FirstName, Salary from Employees 
select * from Employees where HireDate>'2020-12-31'
select * from Employees where Email like '%company.az'

--Aggregate Functions (Toplama funksiyaları):
select max(Salary) as MaxSalary from Employees
select min(Salary) as MinSalary from Employees
select avg(Salary) as AverageSalary from Employees
select count(*) as TotalEmployees from Employees
select sum(Salary) as TotalSalary from Employees

--GROUP BY Query-lər:
select Department, count(*) as EmployeesCount from Employees group by Department
select Department, avg(Salary) as EmployeesAvgSalary from Employees group by Department
select Department, max(Salary) as EmployeesMaxSalary from Employees group by Department

--UPDATE Query-lər:
update Employees set salary = 2800 where EmployeeID = 1
update Employees set salary = salary * 1.10 where Department = 'IT'
update Employees set JobTitle = 'HR Manager' where FirstName = 'Leyla'

--DELETE Query-lər:
delete from Employees where EmployeeID = 5
delete from Employees where Salary<1500

--Əlavə:
select * from Employees where FirstName like '%a%'
select * from Employees where Salary between 2000 and 2500
select * from Employees where Department in('Finance', 'IT')
