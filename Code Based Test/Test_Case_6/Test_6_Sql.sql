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

select * from Code_Employee;

-----------------------------------------------------------------------------------------------------------------------------------

--b. Create a stored procedure to add new employee records. 
--The procedure should accept all the employee details as input parameters, except empno.
--Generate the new employee no in the procedure and then insert the record

create proc addemployees_1
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

