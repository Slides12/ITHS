# Indexering



* Heap table, osorterad data, ny data slängs på högen. Where funktionen tar längre tid då den måste söka igenom all data


*  Clustered index, datan lagrad efter sorterat index. Man kan baraha ett klustrat index per tabell eftersom datan förstås bara kan vara sorterad fysiskt efter en kolumn åt gången. Databashanteraren går igenom ett sökträd.

* Not clustered index, skapar man en separat fysiskt struktur med ett likadant sökträd  med ett likadant sökträd som i ett klsutrat index. skillnaden är att den inte söker direkt mot tabelldata, utan mot en uppsättning referenser till tabelldata.




```SQL

create table indexDemo
(
	a int,
	b int,
	c int
)


select * from indexDemo

truncate table indexDemo

insert into indexDemo select value, 1000001 - value, abs(checksum(newid())) % 10 from generate_series(1,1000000)



create table indexDemoPk
(
	a int primary key,
	b int,
	c int
)


select * from indexDemo where b = 576473

select * from indexDemoPk where a = 576473

truncate table indexDemoPk

insert into indexDemoPk select value, 1000001 - value, abs(checksum(newid())) % 10 from generate_series(1,1000000)





create table indexDemoPk_index
(
	a int primary key,
	b int,
	c int
)

select c from indexDemoPk_index where b = 576473

select b from indexDemoPk where b = 576473

truncate table indexDemoPk

insert into indexDemoPk_index select value, 1000001 - value, abs(checksum(newid())) % 10 from generate_series(1,1000000)



create table indexDemoPk_index_with_c
(
	a int primary key,
	b int,
	c int
)

select c from indexDemoPk_index where b = 576473

select c from indexDemoPk_index_with_c where b = 576473


insert into indexDemoPk_index_with_c select value, 1000001 - value, abs(checksum(newid())) % 10 from generate_series(1,1000000)



```