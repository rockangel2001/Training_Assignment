Create database CodeBased_Test_6
Use Codebased_Test_6

--a. Create a table called Code_Employee(empno int primary key,empname varchar(35), (is a required field)
--empsal numeric(10,2) - (check empsal >=25000) emptype char(1) ) (either 'F' for fulltime or 'P' part time) (Empty Table)

CREATE TABLE Code_Employee (
    empno INT PRIMARY KEY,
    empname VARCHAR(35) NOT NULL,  --required field
    empsal NUMERIC(10,2) CHECK (empsal >= 25000),
    emptype CHAR(1) CHECK (emptype IN ('F', 'P'))
);

-----------------------------------------------------------------------------------------------------------------------------------

--b. Create a stored procedure to add new employee records. 
--The procedure should accept all the employee details as input parameters, except empno.
--Generate the new employee no in the procedure and then insert the record

create procedure AddEmployees
@empno int,
@empname varchar(35),
@empsal decimal(10,2),
@emptype char(1)
as
begin

insert into Code_Employees(empno, empname, empsal, emptype)
values (@empno, @empname, @empsal, @emptype)
end;
exec AddEmployees 7654,'MARTIN',8000.00,'F'
exec AddEmployees 7698,'BLAKE',5001.00,'P'

------------------------------------------------------------------------------------------------------------------------------------





 

