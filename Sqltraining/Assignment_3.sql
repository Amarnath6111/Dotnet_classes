--1
Select EMPNO,ENAME,JOB,SAL,deptno from Emp where job ='MANAGER'
--2
SELECT ename,sal from Emp where sal>1000
--3
select ename,sal from Emp where ename != 'JAMES'
--4
select * from Emp where ename like 's%'
--5
select * from Emp where ename like '%A%'
--6
select * from Emp where ename like '___L%'
--7
SELECT  Ename,sal monthly_salary,SAL/30 as Daily_salary from Emp where  ename='JONES'
--8
select  sum(sal) 'Total Salary' from Emp
--9
declare @avg float
select @avg=avg(sal)  from Emp
print 'the avg annual salary is:  '+''+cast(@avg as varchar(10))
--10
select ename ,job,sal,deptno from Emp where job ='SALESMAN' and deptno=30
--11
select distinct d.Dname from Emp e join Dept d on e.deptno=d.deptno
--12
select ename Employees ,sal 'salary for a month' from Emp where sal>1500 and deptno in (10,30)
--13
select ename,job,sal from Emp where job in('MANAGER','ANALYST') AND (sal not in (1000 , 3000 , 5000))
--14
select ename,sal,comm from Emp where comm>any(select sal+(sal*0.1) as salery from Emp )
--15
select ename from EMp where ename like'%l%l%' and (deptno=30 or mgr_id=7782) 
--16
select ename ,DATEDIFF(year,hiredate,GETDATE()) as age from Emp  where DATEDIFF(year,hiredate,GETDATE()) between 30 and 40
--declare @no int
--select ename ,DATEDIFF(year,hiredate,GETDATE()) age from Emp  where DATEDIFF(year,hiredate,GETDATE()) between 30 and 40 or @no=(select count(*)e from Emp where DATEDIFF(year,hiredate,GETDATE()) between 30 and 40)


--17
select d.Dname ,e.ename from Dept d join Emp e on d.deptno=e.deptno order by d.Dname asc,e.ename desc
--18
select ename ,DATEDIFF(year,hiredate,GETDATE()) as Experience from Emp  where ename ='MILLER'
