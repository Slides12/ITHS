# Stored procedures

Funktion i TSQL
```SQL
create procedure myProcedure as
begin
	print 'Hello world!'
end

exec myProcedure
```

* procedure med parameter:
```SQL
alter procedure myProcedure(@timestamp datetime) as
begin
	print @timestamp;
end

exec myProcedure '2020-01-01'
```


* procedure skillnad mellan klockslag:

```SQL
alter procedure myProcedure(@timestamp datetime) as
begin
	declare @now datetime = getdate();
	select @timestamp as 'Timestamp',
	@now as 'Now',
	datediff(day,@timestamp, @now)
end

exec myProcedure '2020-01-01'
```

* Procedure med flera parametrar och default value:

```SQL
alter procedure myProcedure @timestamp datetime = '2020-01-01', @name nvarchar(20) as
begin
	declare @now datetime = getdate();
	select @timestamp as 'Timestamp',
	@now as 'Now',
	datediff(day,@timestamp, @now),
	@name
end

exec myProcedure '2024-01-01', 'Fredrik'
```


* Med return value
```SQL

alter procedure myProcedure @timestamp datetime = '2020-01-01', @name nvarchar(20) as
begin
	declare @now datetime = getdate();
	select @timestamp as 'Timestamp',
	@now as 'Now',
	datediff(day,@timestamp, @now),
	@name

	return len(@name)
end

exec myProcedure '2024-01-01', 'Fredrik'
```

* While loop som randomiserar med parameter

```SQL
create procedure random @rows int = 1 as
begin
	declare @i int = 1;

	declare @t table
	(
		n int,
		r float
	)

	while @i <= @rows
	begin
		insert into @t values(@i, rand())
		set @i += 1;
	end

	select * from @t
end

exec random 5
``` 


* Ouput, få ett värde från procedure:
```SQL
alter procedure random @rows int = 1, @total float output as
begin
	declare @i int = 1;

	declare @t table
	(
		n int,
		r float
	)

	while @i <= @rows
	begin
		insert into @t values(@i, rand())
		set @i += 1;
	end

	select @total = sum(r) from @t;

	select * from @t
end


declare @result float

exec random 5, @total = @result output

print @result
```


* set no count i koden nedan, tar bort message biten x row affected:
```SQL
alter procedure random @rows int = 1, @total float output as
begin
	set nocount on;

	declare @i int = 1;

	declare @t table
	(
		n int,
		r float
	)

	while @i <= @rows
	begin
		insert into @t values(@i, rand())
		set @i += 1;
	end

	select @total = sum(r) from @t;

	select * from @t

	set nocount off;

end
```