select*from CodeEmployee
drop table CodeEmployee
create table CodeEmployee(
empno int primary key identity,
empname varchar(35) unique,
empsal numeric(10,2) check (empsal>=25000),
emptype char(1))
----
create or alter procedure AddRecord (@empname varchar(35),@empsal numeric(10,2),@emptype char(1))
