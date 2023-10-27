create table students(
student_id int primary key ,
student_name varchar(30),
student_dob varchar(30),
course_id int foreign key references course(course_id)
);

drop table students

select * from students;
select * from course;

create table course(
course_id int primary key,
course_name varchar(30)
);

insert into course values(100,'electrical engineering')
insert into course values(101,'Computer engineering')
insert into course values(102,'Mechanical engineering')
insert into course values(103,'AI engineering')
insert into course values(104,'Biotech engineering')
insert into course values(105,'Civil engineering')
