# VY VIEW


```SQL

drop view myView


create view myView as
select 
	concat(FirstName, ' ' , LastName) as name,
	email,
	phone
from 
	newusers
where FirstName like '[a-d]%'


select * from myView
```

* Alter fungerar också:
```SQL
alter view myView as
select 
	concat(FirstName, ' ' , LastName) as name,
	email,
	phone
from 
	newusers
where FirstName like '[a-d]%'


select * from myView
```


* Nedan har man schemabinding och check option.
Checkoption = du kan inte köra en insert into viewen om det inte matchar kraven nedan (firstname börjar på a-d)
schemabinding  Binds the view to the schema of the underlying table or tables. (Kan ej uppdatera strukturen på tabellen i viewen / kan ej droppa viewen med schemabinding.)

```SQL
alter view dbo.myView with schemabinding as
select 
	concat(FirstName, ' ' , LastName) as name,
	email,
	phone
from 
	dbo.newusers
where FirstName like '[a-d]%' with check option

```