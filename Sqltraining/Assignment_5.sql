select * from tblEmp
--payslip for entire table-----
create or alter procedure GetPayslip
as
begin
select empid,empname,salary,salary*0.1 as HRA,salary*0.2 as DA,(salary+((salary*0.1)  +(salary*0.2))) 'Gross salary',salary*0.08 as PF,
salary*0.05 as IT,(salary*0.08)  +(salary*0.05) 'Total Deductions',((salary+(salary*0.1)+(salary*0.2))-((salary*0.08)+(salary*0.05))) 'Net Salary' from tblEmp 
end

exec GetPayslip
----------------------------------------------------------------------

--for individual employee using procedure
create or alter procedure GetNetSalary (@empid int)
as 
begin
declare @salary float,@GrossSalary float,@Deduction float ,@NetSalary float
--select empid,empname,salary,salary*0.1 as HRA,salary*0.2 as DA,(salary+((salary*0.1)  +(salary*0.2))) 'Gross salary',salary*0.08 as PF,
--salary*0.05 as IT,(salary*0.08)  +(salary*0.05) 'Total Deductions',((salary+(salary*0.1)+(salary*0.2))-((salary*0.08)+(salary*0.05))) 'Net Salary' from tblEmp 
set @salary=(select salary from tblEmp where empid=@empid)
set @Deduction=(@salary*0.08)  +(@salary*0.05)
set @GrossSalary=(@salary+((@salary*0.1)  +(@salary*0.2))) 
set @NetSalary=@GrossSalary-@Deduction
select empid,empname,salary,salary*0.1 as HRA,salary*0.2 as DA,@GrossSalary 'Gross salary',salary*0.08 as PF,salary*0.05 as IT,@Deduction 'Deduction amount',@NetSalary 'Net salary'from tblEmp where empid=@empid
end

exec GetPayslip
exec GetNetSalary 1006
------------------------------------------------

