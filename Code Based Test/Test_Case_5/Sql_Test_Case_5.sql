Create Database Code_base_Test5
Use Code_base_Test5

--Create table named books
CREATE table Books(
id int primary key,
title varchar(20),
author varchar(20),
isbn varchar(20) unique,
published_date datetime
)

--insert values in table named books
insert into Books(id, title, author, isbn, published_date)
values
(1 , 'My First SQL book','Mary Parker', '981483029127', '2012-02-22 12:08:17'),
(2 , 'My Second SQL book', 'John Mayer', '857300923713', '1972-07-03 09:22:45'),
(3 , 'My Third SQL Book', 'Cary Flint', '523120967812', '2015-10-18 14:05:44');

--query to fetch the details of the books written by author whose name ends with er.
select * 
from Books 
where author like '%er';

---------------------------------------------------------------------------------------

--Create table named as reviews
Create table reviews(
id int primary key,
book_id int,
reviewer_name varchar(20),
content varchar(20),
rating int,
published_date datetime
)

--insert values to table named reviews
insert into reviews(id, book_id, reviewer_name, content, rating, published_date)
values
(1, 1, 'John Smith', 'My First review', 4, '2017-12-10 05:50:11'),
(2, 2, 'John Smith', 'My second review', 5, '2017-10-13 15:05:12'),
(3, 2, 'Alice Walker', 'My another review', 1, '2017-10-22 23:47:10');

--query to Display the Title ,Author and ReviewerName for all the books from the above table 
SELECT books.title, books.author,reviews.reviewer_name FROM books
INNER JOIN reviews ON books.id =reviews.book_id;

--Display the  reviewer name who reviewed more than one book.
select reviewer_name from reviews group by reviewer_name
having count (distinct book_id) >1;

------------------------------------------------------------------------------------------------

--Create table named as Customers
Create Table Customers(
id int primary key,
name varchar(20) ,
age int ,
address varchar(20),
salary decimal
)

--Insert values to table named as Customers
insert into Customers(id, name, age, address, salary)
values
(1,'Ramesh', 32, 'Ahmedabad', 2000.00),
(2, 'Khilan', 25, 'Delhi', 1500.00),
(3,'kaushik', 23, 'Kota', 2000.00),
(4, 'Chaitali', 25, 'Mumbai', 6500.00),
(5, ' Hardik', 27, 'Bhopal', 8500.00),
(6, 'Komal', 22, 'MP', 4500.00),
(7, 'Muffy', 24, 'Indore', 10000.00);

--query to Display the Name for the customer from above customer table 
--who live in same address which has character o anywhere in address
Select name from Customers where address like '%o%';

----------------------------------------------------------------------------

--Create table named as orders
create table orders(
OID int,
date datetime,
customer_id int,
amount int)

--insert values in orders table
insert into orders(OID,date,customer_id,amount)
values
(102, '2009-10-08 00:00:00', 3, 3000),
(100, '2009-10-08 00:00:00', 3, 1500),
(101, '2009-11-20 00:00:00', 2, 1560),
(103, '2008-05-20 00:00:00', 4, 2060);

--query to display the Date,Total no of customer  placed order on same Date 
Select Date, Count(Distinct CUSTOMER_ID) as total_customers from orders
group by date 
having count(distinct customer_id)>1;

--------------------------------------------------------------------------------------

--create table named as Employee
Create table Employee(
ID int primary key,
Name varchar(20),
Age int,
Address varchar(20),
Salary decimal
)

--insert values to Employee table
insert into Employee(ID, Name, Age, Address, Salary)
values
(1,'Ramesh', 32, 'Ahmedabad', 2000.00),
(2, 'Khilan', 25, 'Delhi', 1500.00),
(3,'kaushik', 23, 'Kota', 2000.00),
(4, 'Chaitali', 25, 'Mumbai', 6500.00),
(5, ' Hardik', 27, 'Bhopal', 8500.00),
(6, 'KOMAL', 22, 'MP', null),
(7, 'MUFFY', 24, 'Indore',null);

--query to Display the Names of the Employee in lower case, whose salary is null 
select lower(Name) as Lowercase_Name
from Employee where Salary is null

-----------------------------------------------------------------------------------

--Create table named as Studentdetails
Create table Studentdetailss(
RegisterNo int, 
Name Varchar(20),
Age int,
Qualification varchar(10),
MobileNo varchar(20),
Mail_id varchar(10),
Location varchar(20),
Gender varchar(1)
)

--insert table named studentdetails
INSERT INTO Studentdetailss(RegisterNo, Name, Age, Qualification, MobileNo, Mail_id, Location,Gender) 
VALUES 
(2, 'Sai', 22, 'BE', '9952836777', 'Sai@gmai.com', 'Chennai','M'),
(3, 'Kumar', 20, 'BSC', '7890125648', 'Kumar@gmail.com', 'Madurai','M'),
(4, 'Selvi', 22, 'B. Tech', '8904567342', 'selvi@gnai.com', 'Salem','F'),
(5, 'Nisha', 25, 'M.E', '7834672310', 'nisha@gmail.com', 'Theni','F'),
(6, 'SaiSaran', 21, 'B.A', '7890345678', 'saran@gmai.com', 'Madurai','M'),
(7, 'Tom', 23, 'BCA', '8901234675', 'Tom@gmail.com', 'Pune','M');

--a sql server query to display the Gender,Total no of male and female from the above a relation.
select isnull(gender,'Not Assigned') as gender, count(RegisterNo) as 'Total Employee' from Studentdetailss
group by gender;