--a. Create a table called Code_Employee(empno int primary key,empname varchar(35), (is a required field)
--empsal numeric(10,2) - (check empsal >=25000) emptype char(1) ) (either 'F' for fulltime or 'P' part time) (Empty Table)

CREATE TABLE Code_Employee (
    empno INT PRIMARY KEY,
    empname VARCHAR(35) NOT NULL,  --required field
    empsal NUMERIC(10,2) CHECK (empsal >= 25000),
    emptype CHAR(1) CHECK (emptype IN ('F', 'P'))
);

select * from Code_Employee;

-----------------------------------------------------------------------------------------------------------------------------------

--b. Create a stored procedure to add new employee records. 
--The procedure should accept all the employee details as input parameters, except empno.
--Generate the new employee no in the procedure and then insert the record

create proc addemployee
@empname varchar(35),
@empsal decimal(10,2),
@emptype char(1)
as
begin
declare @newempno int ;
select @newempno = ISNULL(max(empno),0)+1 from code_employee;

insert into code_employee(empno , empname , empsal,emptype)
values(@newempno,@empname,@empsal,@emptype)
end

------------------------------------------------------------------------------------------------------------------------------------
/*II. Write a Cursor program, that retrieves all the employees and updates salary for all employees 

of Department 10(Accounting) by 15%*/

USE Assignment2;

-- Declare the variables for the cursor
DECLARE @empno NUMERIC(4);
DECLARE @sal INT;

-- Declare the cursor
DECLARE employee_cursor CURSOR FOR
SELECT empno, sal
FROM employees
WHERE deptno = 10;

-- Open the cursor
OPEN employee_cursor;

-- Fetch the first row
FETCH NEXT FROM employee_cursor INTO @empno, @sal;

-- Loop through the cursor
WHILE @@FETCH_STATUS = 0
BEGIN

-- Update the salary with a 15% increase
UPDATE employees
SET sal = sal * 1.15
WHERE empno = @empno;

-- Fetch the next row
FETCH NEXT FROM employee_cursor INTO @empno, @sal;
END

-- Close and deallocate the cursor
CLOSE employee_cursor;
DEALLOCATE employee_cursor;

-- Select the updated records to verify
SELECT * FROM employees WHERE deptno = 10;
