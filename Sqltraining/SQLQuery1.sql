create table Clients(
Client_ID int primary key,
Cname varchar(40) not null,
addres varchar(30),
Email varchar(30) unique,
Phone int,
Business varchar(30) not null)
insert into Clients values (1001,'ACME Utilities','Noida','contact@acmeutil.com',9567880032,'Manufacturing')
---------Employee
create table Employees(
Empno int primary key,
Ename varchar(20),
Job varchar(15),
Salary int check (Salary>0),
Deptno int foreign key REFERENCEs Departments(Deptno))
--Departments
create table Departments(
Deptno int primary key,
Dname varchar(15)not null,
Loc varchar(20))
------Projects
create table Projects(
Project_ID int primary key,
Descr varchar(30) not null,
Start_Date Date,
Planned_End_Date Date,
Actual_End_date Date check (Planned_End_Date <= Actual_End_date))