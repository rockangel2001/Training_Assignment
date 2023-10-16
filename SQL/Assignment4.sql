create database Assignment4
use Assignment4

-- Declare variables
declare @Number int = 5 -- Change this to the desired number for which you want to calculate the factorial
declare @Factorial bigint = 1
declare @Counter int = 1

-- Calculate factorial using a loop
while @Counter <= @Number
begin
    set @Factorial = @Factorial * @Counter
    set @Counter = @Counter + 1
end

-- Output the factorial result
select 'The factorial of ' + cast(@Number as varchar) + ' is ' + cast(@Factorial as varchar)


--------------------------------------------------------------------------------------------------------------------------

-- Create a stored procedure to generate multiplication tables
create procedure gmtables
@num int
as 
begin 
declare @multi int =1

while @multi <= 10
begin
 declare @result int = @num * @multi
 print concat(@num,'x',@multi,'=',@result)
 set @multi = @multi +1
 end
end
--to execute
exec gmtables @num = 5;

-----------------------------------------------------------------------------------------------------------------------------------

use Assignment2;

--3.  Create a trigger to restrict data manipulation on EMP table during General holidays. Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali", you cannot manupulate" etc Note: Create holiday table as (holiday_date,Holiday_name) store at least 4 holiday details. try to match and stop manipulation 
create table Holidays
(holiday_date Date Primary Key, holiday_name nvarchar(max));

INSERT INTO HOLIDAYs values
('2023-01-01','NewYear'),
('2023-08-15','Independence Day'),
('2023-10-27','Diwali'),
('2023-12-25','Christmas'),
('2023-10-16','Homieday');

CREATE TRIGGER RestrictDataholiday
ON Employees
FOR INSERT, UPDATE, DELETE 
AS 
BEGIN     
DECLARE @Holiday_name VARCHAR(50), @holiday_date DATE
SET @holiday_date = CONVERT(DATE, GETDATE())
SELECT @Holiday_name = Holiday_name     
FROM Holidays     
WHERE holiday_date = @holiday_date 
IF @holiday_name IS NOT NULL     
BEGIN         
ROLLBACK TRANSACTION        
RAISERROR('Due to %s, you cannot manipulate data', 16, 1, @holiday_name)     
END 
END

select * from employees;

insert into employees values(7777,'shreya', 'manager', 8900,'1980-12-20',88800,null,20)


