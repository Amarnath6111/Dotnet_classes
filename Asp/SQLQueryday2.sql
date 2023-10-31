create table tblEmp (
empid int primary key,
empname varchar(30) not null,
project varchar(30),
salary int,
location varchar(30),)
insert into tblemp values(1001,'Amarnath','molina',12000,'hyderabad'),
(1006,'sai','molina',12500,'hyderabad'),
(1004,'hari','molina',10000,'hyderabad'),
(1011,'shiva','molina',14000,'vizag'),
(1021,'ram','medica',12000,'hyderabad'),
(1016,'sai ram','molina',12500,'hyderabad'),
(1024,'haricharan','molina',18000,'hyderabad'),
(1081,'sainath','molina',14200,'vizag'),
(1031,'ramesh','medica',12000,'hyderabad')
select * from tblEmp
select empname ,project from tblEmp where location='hyderabad'
select * from tblemp where salary>=15000
select * from tblemp where salary   between 13000 and 15000
select top 3 * from tblEmp 
select top 30 percent * from tblEmp
select max(salary) as Maximum,min(salary) Minimum,sum(salary) as total,AVG(salary) as average from tblEmp
select * from tblEmp where empname like'A%'
select * from tblEmp where empname like'%h'
select * from tblEmp where empname like'ama%'
select * from tblEmp where empname like'___r%'
select * from tblEmp where empname like'A[ma]%'
select * from tblEmp where empname like'__[ia]%'
delete  from tblEmp where empid=1011 



