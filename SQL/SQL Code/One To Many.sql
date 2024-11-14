drop table countries;
drop table cities;

create table Countries
(
	id int,
	name nvarchar(max)
);


insert into Countries values(1,'Sweden');
insert into Countries values(2,'Norway');
insert into Countries values(3,'Denamrk');
insert into Countries values(4,'Finland');



create table cities
(
	id int,
	name nvarchar(max),
	countryId int
);


insert into cities values(1,'Stockholm',1);
insert into cities values(2,'Gothenburg',1);
insert into cities values(3,'Malmö',1);
insert into cities values(4,'Oslo',2);
insert into cities values(5,'Bergen',2);
insert into cities values(6,'Köpenhamn',3);
insert into cities values(7,'London',8);

select * from Countries;
select * from cities;


select cities.id, 
cities.name as 'City',
Countries.name as 'Country',
countryId
from countries
full join cities on countries.id = cities.countryId

-- Uppgift: skriv en select som tar ut alla länder med kolumnerna id, landsnamn och en tredje kolumn med antal städer, en fjärde kolumn med namnen komma separerade.




select
	co.id,
	co.name as 'Country',
	count(ci.id) as 'Cities',
	isnull(string_agg(ci.name, ', '),'-') as 'City Names'
from Countries co
left join cities ci
on co.id = ci.countryId
group by co.id, co.name


