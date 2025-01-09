drop table countries;
drop table cities;

create table Countries
(
	id int primary key,
	name nvarchar(max)
);


insert into Countries values(1,'Sweden');
insert into Countries values(2,'Norway');
insert into Countries values(3,'Denamrk');
insert into Countries values(4,'Finland');



create table cities
(
	id int primary key,
	name nvarchar(max),
	countryId int foreign key references countries(id)
);


insert into cities values(1,'Stockholm',1);
insert into cities values(2,'Gothenburg',1);
insert into cities values(3,'Malm�',1);
insert into cities values(4,'Oslo',2);
insert into cities values(5,'Bergen',2);
insert into cities values(6,'K�penhamn',3);
--insert into cities values(7,'London',8); // G�r ej d� foreign id'et inte finns i countries. 8an.

select * from Countries;
select * from cities;



--update cities set countryid = 7 where id = 6 // g�r inte att byta k�penhamn till ett annat land.

update cities set countryid = 3 where id = 6 -- g�r s� l�nge foreign keyn finns.


-- delete from Countries where id = 1 // G�r inte att ta bort sverige d� det finns data som �r beroende av just det id'et

delete from Countries where id = 4 -- G�r d� det finns ingen stad kopplad mot finland.

begin transaction

delete from Countries where id = 2
update Countries set id = 12 where id = 1;

rollback
