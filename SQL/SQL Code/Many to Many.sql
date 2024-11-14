drop table students
drop table courses

create table courses
(
	id int,
	name nvarchar(max)
);

insert into courses values(1, 'C#');
insert into courses values(2, 'Databaser');
insert into courses values(3, 'Javascript');
insert into courses values(4, 'Databehandling');
insert into courses values(5, 'Clean code');


create table students
(
	id int,
	name nvarchar(max)
);


insert into students values(1, 'Emma');
insert into students values(2, 'Thomas');
insert into students values(3, 'Stefan');
insert into students values(4, 'Camilla');
insert into students values(5, 'Maria');
insert into students values(6, 'Anna');
insert into students values(7, 'Karl');


 create table coursesStudents
 (
	courseId int,
	studentId int
 )

 insert into coursesStudents values(1,1)
 insert into coursesStudents values(1,4)
 insert into coursesStudents values(1,5)
 insert into coursesStudents values(1,7)
 insert into coursesStudents values(2,1)
 insert into coursesStudents values(2,2)
 insert into coursesStudents values(2,5)
 insert into coursesStudents values(3,2)
 insert into coursesStudents values(3,3)
 insert into coursesStudents values(3,4)
 insert into coursesStudents values(3,5)
 insert into coursesStudents values(3,7)
 insert into coursesStudents values(4,4)
 insert into coursesStudents values(4,5)
 insert into coursesStudents values(4,7)




select * from students
select * from courses
select * from coursesStudents


select c.name as 'Kurs',
count(s.name)
from courses c
join coursesStudents cs on c.id = cs.courseId
join students s on cs.studentId = s.id
group by c.name


select s.name as 'Kurs',
count(c.name)
from courses c
join coursesStudents cs on c.id = cs.courseId
join students s on cs.studentId = s.id
group by s.name