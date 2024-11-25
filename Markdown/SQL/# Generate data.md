# Generate data time taken for different code

insert into demodata default values
go 100000
Tog : 27 sekunder.

While loopen tog: 9 Sekunder.

insert into demoData(time) select GETDATE() from generate_series(1,100000)
Tog: 0 sekunder.

```SQL
drop table demodata

create table demoData
(
	id int primary key identity(1,1),
	time datetime2 default(Getdate())
)
go

truncate table demodata


insert into demoData default values;
go 100000


select * from demoData
go

declare @i int = 0

while @i < 100000
begin

	insert into demoData default values;
	set @i += 1

end

select * from generate_series(1,100)

insert into demoData(time) select GETDATE() from generate_series(1,100000)



```