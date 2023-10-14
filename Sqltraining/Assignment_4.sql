--factorial
begin 
declare @fno int
declare @factorial int
declare @temp int
set @factorial=1
set @fno=5
set @temp=@fno
while (@temp>0)
begin 
set @factorial=@factorial*@temp
set @temp=@temp-1
end
print 'the factorial of :'+ ' '+cast(@fno as varchar(10))+' '+'is'+' '+cast(@factorial as Varchar(10))
select @factorial as 'factorial of number'
end

--multiplication table

create or alter procedure MultiplyTable @table int
as 
begin
declare @a int
declare @b int
if @table <= 0
begin
print 'Invalid value, please enter a +ve value'
return
end
set @a = 9
while @a <= @table 
begin 
print 'multiplication table for ' + cast(@a as varchar(10)) + 'is:'
set @b = 1
while @b<=10
begin
print cast(@a as varchar(10)) + ' * ' + cast(@b as varchar(10)) + ' = ' + cast(@a * @b as varchar(10))
set @b = @b+1
end
print ''
set @a = @b + 1
end
end

exec MultiplyTable @table = 10;





--Holidays Trigger
create table Holidays(
hdate date,
hname varchar(30)
);

insert into Holidays (hdate, hname) values
('2023-01-26', 'Republic Day'),
('2023-05-01', 'May Day'),
('2023-08-15', 'Independence Day'),
('2023-10-02', 'Gandhi Jayanthi'),
('2023-10-14', 'Vijaya Dashami'),
('2023-11-13', 'Diwali'),
('2023-12-25', 'Christmas')

drop table Holidays
 
create or alter  trigger holidayTrigger on Employees
after insert, update, delete as
begin
declare @hname varchar(20);
select @hname = hname from Holidays
where hdate = convert(date, getdate());
if @hname is not null
begin
declare @errmessage varchar(50);
set @errmessage = 'Due to the ' + @hname + ' You Cannot Manipulate or change data';
throw 51000, @errmessage, 1;
end 
end;

select * from Holidays;
update Employees set salary = 31000 where empno = 7010;
select* from Employees