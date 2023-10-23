--II. Write a Cursor program, that retrieves all the employees and updates salary
 --for all employees of Department 10(Accounting) by 15%

use Assignment2

-- Declare the variables for the cursor
declare @empno numeric(4);
declare @sal int;

-- Declare the cursor
declare employee_cursor cursor for
select empno, sal from employees where deptno = 10;

-- Open the cursor
open employee_cursor;

-- Fetch the first row
fetch next from employee_cursor into @empno, @sal;

-- Loop through the cursor
while @@FETCH_STATUS = 0
begin

-- Update the salary with a 15% increase
update employees
set sal = sal * 1.15
where empno = @empno;

-- Fetch the next row
fetch next from employee_cursor into @empno, @sal;
end

-- Close and deallocate the cursor
close employee_cursor;
DEALLOCATE employee_cursor;

-- Select the updated records to verify
SELECT * FROM employees WHERE deptno = 10;



 

