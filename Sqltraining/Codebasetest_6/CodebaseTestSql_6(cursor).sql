select * from Emp where deptno=10
declare @empno int;
declare @sal int;
declare empCursor cursor for select empno, sal from Emp where deptno = 10;
open empCursor;
fetch next from empCursor into @empno, @sal;
while @@FETCH_STATUS = 0
begin
set @sal =@sal+( @sal *0.15) 
update Emp 
set sal= @sal where empno = @empno;
fetch next from empCursor into @empno, @sal;
end;
close empCursor;
deallocate empCursor;