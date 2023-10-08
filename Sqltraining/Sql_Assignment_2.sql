create table Emp(
empno int,ename varchar(30),job varchar(30),mgr_id varchar(30),hiredate date,sal int ,comm int,deptno int)
select * from  Emp
insert into Emp values (7369 , 'SMITH',   'CLERK',	   	7902,   '1980-12-17'   ,  	 800	,null  ,  20)
insert into Emp values (7499  ,  'ALLEN'  , 'SALESMAN'  , 7698 ,  	'1981-02-20'  ,	 1600 ,   300  ,  30),
(7521   , 'WARD'	, 'SALESMAN' ,  7698 ,  '1981-02-22' , 	 1250 ,    500,    30),
(7566  ,  'JONES'  ,  'MANAGER'    ,7839 ,  '1981-04-02' ,   2975 ,   null,    20),
(7654 , ' MARTIN' ,   'SALESMAN'   ,7698 ,  '1981-09-28'  	,1250,    1400,    30),
(7698	,'BLAKE',     'MANAGER'    ,7839, 	  '1981-05-01'  ,2850 ,  null,     30),
(7782  , 'CLARK' ,   'MANAGER'     ,7839 ,	'1981-06-09'  , 2450 ,   null   ,  10),
(7788 ,  'SCOTT' ,   'ANALYST'     ,7566,   '1987-04-19' ,  3000,    null   ,   20),
(7839  ,  'KING'  ,  'PRESIDENT'  ,  null, '1981-11-17' ,   5000 ,  null,      10),
(7844 ,   'TURNER',  'SALESMAN'    ,7698 ,  '1981-09-08' ,  1500   ,    0 ,    30),
(7876  ,  'ADAMS'  ,  'CLERK'     , 7788 ,   '1987-05-23' ,   1100 ,  null ,    20),
(7900  ,  'JAMES'   , 'CLERK'     ,7698   ,	 '1981-12-03' ,  950 ,   null   ,   30),
(7902  ,  'FORD'  ,   'ANALYST'  ,  7566  , '1981-12-03'   , 3000,   null   ,   20),
(7934  ,  'MILLER'  ,  'CLERK'     ,  7782  ,  '1982-01-23', 1300, null    ,    10)
create table Dept(
deptno int, Dname varchar(30),Loc varchar (30))
select * from Dept
drop table Dept
insert into Dept values(10 ,    'ACCOUNTING'  ,  'NEW YORK'),
(20  ,   'RESEARCH'   ,   'DALLAS'), 
(30 ,    'SALES'      ,   'CHICAGO'), 
(40  ,   'OPERATIONS'  ,  'BOSTON' )
select *from Emp where ename like 'A%'
select empno,ename,job,mgr_id,deptno from Emp where mgr_id is  null
select empno,ename,sal from Emp where sal  between 1200 and 1400
select empno ,ename,deptno,sal from Emp where deptno=20
select empno ,ename,deptno, sal+(sal*0.1)  Salary_rise from Emp where deptno=20
select empno,ename,job as job_position_as_clerks from Emp where job='CLERK'
select job ,AVG(sal)  Average_of_each_jobtype ,count(job) total_number
from Emp group by job
select empno,ename,sal as min_max_salary  from Emp where sal=(select max(sal) from emp) or sal =(select min(sal) from emp)
select d.deptno,Dname,Loc from Emp e right join Dept d on e.deptno=d.deptno where empno is null 
select Ename  ,sal,job,deptno from Emp where job='ANALYST'and sal>1200 and deptno=20 order by ename
select e.deptno, Dname , sum(sal) Total_salary from Dept d  join Emp e on d.deptno=e.deptno  where deptno=any(select deptno  from Emp group by deptno) 
select e.deptno, Dname , sum(sal) Total_salary from Dept d  join Emp e on d.deptno=e.deptno  group by e.deptno,Dname
select ename,sal from Emp where ename ='MILLER' or  ename='SMITH'
SELECT Ename from Emp where ename like 'A%' or ename like 'M%'
select ename ,sal*12 as Yearly_salary from Emp where ename='SMITH'
select ename ,sal from Emp where sal<1500 or sal>2850 
select ename ,sal from Emp where sal not between 1500 and 2850
select mgr_id ,count(empno) no_of_emp_reporting from Emp group by mgr_id having count(empno)>2
