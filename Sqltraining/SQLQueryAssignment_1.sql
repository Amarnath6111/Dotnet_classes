use SqlAmar
create table Clients(
Client_ID int primary key,
Cname varchar(40) not null,
addres varchar(30),
Email varchar(30) unique,
Phone bigint,
Business varchar(30) not null)
drop table Clients
insert into Clients values (1001,'ACME Utilities','Noida','contact@acmeutil.com',9567880032,'Manufacturing')
insert into Clients values(1002,'Trackon Consultants','Mumbai','consult@trackon.com',8734210090,'Consultant'),
(1003,'Money saver Distributors','Kolkata','save@moneysaver.com',7799886655,'Reseller'),
(1004,'Lawful Corp','chennai','justice@lawful.com',9210342219,'Proffessional')
select * from Clients
---------Employee
create table Employees(
Empno int primary key,
Ename varchar(20),
Job varchar(15),
Salary int check (Salary>0),
Deptno int foreign key REFERENCEs Departments(Deptno))
insert into Employees values(
7001 ,'Sandeep' ,'Analyst', 25000, 10),

(7002, 'Rajesh' ,'Designer' ,30000, 10),

(7003, 'Madhav' ,'Developer' ,40000, 20),

(7004, 'Manoj' ,'Developer' ,40000 ,20),

(7005, 'Abhay' ,'Designer' ,35000, 10),

(7006 ,'Uma', 'Tester' ,30000 ,30),

(7007 ,'Gita', 'Tech.Writer' ,30000 ,40),

(7008 ,'Priya' ,'Tester' ,35000 ,30),

(7009, 'Nutan' ,'Developer' ,45000, 20),

(7010 ,'Smita' ,'Analyst' ,20000 ,10),

(7011 ,'Anand', 'Project Mgr' ,65000 ,10)
select * from Employees
--Departments
create table Departments(
Deptno int primary key,
Dname varchar(15)not null,
Loc varchar(20))
insert into Departments values(10, 'Design', 'Pune'),

(20 ,'Development', 'Pune'),

(30, 'Testing', 'Mumbai'),

(40 ,'Document' ,'Mumbai')
select * from Departments
------Projects
create table Projects(
Project_ID int primary key,
Descr varchar(30) not null,
Start_Date Date,
Planned_End_Date Date,
Actual_End_date Date ,
Budget int ,
Client_ID int,
foreign key(Client_ID) references Clients(Client_ID),
Constraint budgetcheck Check (Budget > 0),
constraint valid check (Planned_End_Date <= Actual_End_date));
drop table Projects
select * from Projects
insert into Projects values (401, 'Inventory', '2011-04-01', '2011-10-01', '2011-10-31' ,150000, 1001)

insert into Projects values (402 ,'Accounting' ,'2011-08-01' ,'2012-01-01' ,null,500000 ,1002),

(403, 'Payroll' ,'2011-10-01' ,'2011-12-31',null, 75000, 1003),

(404 ,'Contact Mgmt' ,'2011-11-01' ,'2011-12-31' ,null,50000, 1004)
--EmpProjectTasks Table
create table EmpProjTasks
(Project_ID int ,
Foreign key (Project_ID) references Projects(Project_ID),
Empno int foreign key (Empno) references Employees(Empno) , 
--foreign key(Empno) references Employees(Empno),
Start_Date Date,
End_Date Date,
Task varchar(25) not null,
Status varchar(15)
primary key(Empno,Project_ID));
drop table EmpProjTasks
select * from EmpProjTasks
insert into EmpProjTasks values
(401 ,7001 ,'2011-04-01','2011-04-20', 'System Analysis', 'Completed'),

(401, 7002, '2011-04-21', '2011-05-30', 'System Design', 'Completed'),

(401 ,7003 ,'2011-07-01' ,'2011-07-15' ,'Coding' ,'Completed'),

(401, 7004, '2011-07-18', ' 2011-09-01', 'Coding', 'Completed'),

(401 ,7006, ' 2011-09-03' ,'2011-09-15' ,'Testing' ,'Completed'),

(401, 7009, '2011-09-18' ,'2011-10-05' ,'Code Change', 'Completed'),

(401 ,7008 ,'2011-10-06', '2011-10-16' ,'Testing', 'Completed'),

(401, 7007, '2011-10-06', '2011-10-22' ,'Documentation' ,'Completed'),

(401 ,7011 ,'2011-10-22', '2011-10-31' ,'Sign off' ,'Completed'),

(402, 7010, '2011-08-01' ,'2011-08-20' ,'System Analysis' ,'Completed'),

(402 ,7002 ,' 2011-08-22' ,'2011-09-30' ,'System Design' ,'Completed'),

(402, 7004, '2011-10-01' ,null,'Coding ','In Progress')