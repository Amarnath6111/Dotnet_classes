select*from CodeEmployee
drop table CodeEmployee
create table CodeEmployee(
empno int primary key identity,
empname varchar(35) unique,
empsal numeric(10,2) check (empsal>=25000),
emptype char(1))
----
create or alter procedure AddRecord (@empname varchar(35),@empsal int,@emptype char(1))
as
begin
insert into CodeEmployee values(@empname,@empsal,@emptype)
select * from CodeEmployee
end

exec AddRecord 'Amarnath',27000,'p'