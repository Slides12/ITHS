# Övningsuppgifter med join

Många gånger när någon kund eller kollega vill ha hjälp att få ut data ur en databas så har de ingen aning om vilka specifika kolumner eller tabeller datan är lagrad i. Då får man hjälpa till med lite detektivarbete. Om databasen är någorlunda välstrukturerad kan man oftast, utifrån namnen, gissa sig till vad de olika tabellerna innehåller och hur de är relaterade.

Vid det här laget har ni de flesta verktyg ni behöver för att skriva queries och få ut den information ni letar efter. Nu är det dags att börja gräva runt bland data i everyloop för att hitta svar på specifika frågor.

Svara på frågorna i övningarna nedan, och redovisa hur ni kommit fram till svaret.

## A - Company

Med tabellerna från schema “company”, svara på följande frågor:

1. Företagets totala produktkatalog består av 77 unika produkter. Om vi kollar bland våra ordrar, hur stor andel av dessa produkter har vi någon gång leverarat till London?

```SQL
-- Answer
-- 41/77 (53,25 %)
select 
	o.ShipCity as 'City',
	count(distinct od.ProductId) as 'Unique products ordered',
	Format(cast(count(distinct od.ProductId) as decimal) / (select count(*) from company.products), 'P') as 'Percentage of products sold to London'
from company.orders o 
	join company.order_details od on o.id = od.OrderId
where ShipCity = 'London'
group by
	o.ShipCity
```

2. Till vilken stad har vi levererat flest unika produkter?

```SQL
-- Answer
-- Boise (45 st)
select 
	o.ShipCity,
	count(distinct p.Id) as 'number of unique products'
from 
	company.products p 
left join 
	company.order_details od 
on 
	od.ProductId = p.Id 
left join 
	company.orders o
on
	od.OrderId = o.Id
group by o.ShipCity
order by [number of unique products] desc
```


3. Av de produkter som inte längre finns I vårat sortiment, hur mycket har vi sålt för totalt till Tyskland?

```SQL
-- Answer
-- 577,59
select 
	o.ShipCountry,
	sum(p.UnitPrice) as 'total discontinued sold for'
from 
	company.products p 
left join 
	company.order_details od 
on 
	od.ProductId = p.Id 
left join 
	company.orders o
on
	od.OrderId = o.Id
	where Discontinued = 1
	and
	ShipCountry = 'Germany'
group by o.ShipCountry
```

4. För vilken produktkategori har vi högst lagervärde?

```SQL
-- Answer
-- Côte de Blaye (4479,5)
select 
	distinct ProductName,
	UnitsInStock,
	p.UnitPrice,
	CategoryId,
	UnitsInStock * p.UnitPrice as 'stock value'
from 
	company.products p 
left join 
	company.order_details od 
on 
	od.ProductId = p.Id 
left join 
	company.orders o
on
	od.OrderId = o.Id
	order by [stock value] desc
```


5. Från vilken leverantör har vi sålt flest produkter totalt under sommaren 2013?


```SQL
-- Answer
-- Plutzer Lebensmittelgroßmärkte AG (9 st)
select 
	p.Id,
	p.ProductName,
	SupplierId,
	count(OrderId) as 'orders per product',
	CompanyName
	
from 
	company.products p 
left join 
	company.order_details od 
on 
	od.ProductId = p.Id 
left join 
	company.orders o
on
	od.OrderId = o.Id
left join 
	company.suppliers s
on
	p.SupplierId = s.Id
	where cast(OrderDate as datetime2) between cast('2013-06-01' as datetime2) and cast('2013-09-01' as datetime2)
group by p.ProductName,p.Id, SupplierId, s.CompanyName
order by [orders per product] desc
```
   
## B - Playlist
Använd dig av tabellerna från schema “music”, och utgå från:
```sql 
declare @playlist varchar(max) = 'Heavy Metal Classic';
```
Skriv sedan en select-sats som tar ut alla låtar från den lista som
angivits i @playlist efter följande exempel: 


| Genre         | Artist        | Album          | Track        | Length      | Size     | Composer    |
| -----------   | -----------   | -----------    | -----------  | ----------- | -------- | ----------- |
| Heavy Metal   | Iron Maiden   | Killers        | Killers      | 05:00       | 6.9 MiB  | Steve Harris|
| Heavy Metal   | Iron Maiden   | Killers        | Wrathchild   | 02:54       | 4.0 MiB  | Steve Harris|
| Metal         | Black Sabbath | Black Sabbath  | N.I.B        | 06:08       | 11.5 MiB | -           |

``... Resten av låtarna``


```SQL
-- Answer
declare @playlist varchar(max) = 'Heavy Metal Classic';

select
	g.Name as Genre,
	ar.Name as Artist,
	al.Title as Album,
	t.Name as Track,
	concat(format(datepart(minute,dateadd(MILLISECOND,t.Milliseconds, '19700101')),'00'), ':',format(datepart(second,dateadd(MILLISECOND,t.Milliseconds, '19700101')),'00')) as Length,
	concat(format(t.Bytes / 1048576.0,'0.0'), ' MiB') as Size,
	ISNULL(t.Composer,'-') as Composer
from
	music.artists ar
left join 
	music.albums al
on 
	ar.ArtistId = al.ArtistId
left join 
	music.tracks t
on 
	al.AlbumId = t.AlbumId
left join 
	music.genres g
on
	t.GenreId = g.GenreId
left join 
	music.playlist_track pt
on 
	pt.TrackId = t.TrackId
left join 
	music.playlists p
on p.PlaylistId = pt.PlaylistId
where 
	p.Name = @playlist
order by 
	genre,composer,track 
```


## C - Music

Med tabellerna från schema “music”, svara på följande frågor:

1. Av alla audiospår, vilken artist har längst total speltid?

```SQL
-- Answer
-- Battlestar Galactica (Classic) (49:20)
select
	ar.Name as Artist,
	t.Name as TrackName,
	concat(format(datepart(minute,dateadd(MILLISECOND,t.Milliseconds, '19700101')),'00'), ':',format(datepart(second,dateadd(MILLISECOND,t.Milliseconds, '19700101')),'00')) as [Total Play time]
from
	music.artists ar
left join 
	music.albums al
on 
	ar.ArtistId = al.ArtistId
left join 
	music.tracks t
on 
	al.AlbumId = t.AlbumId
left join 
	music.genres g
on
	t.GenreId = g.GenreId
left join 
	music.playlist_track pt
on 
	pt.TrackId = t.TrackId
left join 
	music.playlists p
on p.PlaylistId = pt.PlaylistId
order by [Total Play time] desc

```

2. Vad är den genomsnittliga speltiden på den artistens låtar?

```SQL
-- Answer
-- Battlestar Galactica (Classic) (48:45)

select
	ar.Name as Artist,
	concat(format(datepart(minute,dateadd(MILLISECOND,avg(t.Milliseconds), '19700101')),'00'), ':',format(datepart(second,dateadd(MILLISECOND,avg(t.Milliseconds), '19700101')),'00')) as [Average Play time]
from
	music.artists ar
left join 
	music.albums al
on 
	ar.ArtistId = al.ArtistId
left join 
	music.tracks t
on 
	al.AlbumId = t.AlbumId
left join 
	music.genres g
on
	t.GenreId = g.GenreId
left join 
	music.playlist_track pt
on 
	pt.TrackId = t.TrackId
left join 
	music.playlists p
on p.PlaylistId = pt.PlaylistId
where ar.Name = 'Battlestar Galactica (Classic)'
group by ar.Name


```

3. Vad är den sammanlagda filstorleken för all video?

```SQL
-- Answer
-- 171575.7 MiB, 167.6 GiB
select
	concat(format(sum(cast(t.Bytes as bigint)) / 1048576.0,'0.0'), ' MiB') as Size
from
	music.artists ar
left join 
	music.albums al
on 
	ar.ArtistId = al.ArtistId
left join 
	music.tracks t
on 
	al.AlbumId = t.AlbumId
left join 
	music.genres g
on
	t.GenreId = g.GenreId
left join 
	music.playlist_track pt
on 
	pt.TrackId = t.TrackId
left join 
	music.playlists p
on p.PlaylistId = pt.PlaylistId
where p.PlaylistId = 2
or
	p.PlaylistId = 3
or
	p.PlaylistId = 7
or
	p.PlaylistId = 9
or
	p.PlaylistId = 10
```

4. Vilket är det högsta antal artister som finns på en enskild spellista?


```SQL
-- Answer
-- Music, 198 unique artists
select
	p.Name as Artist,
	count(distinct ar.Name) as 'Number of artists'
from
	music.artists ar
left join 
	music.albums al
on 
	ar.ArtistId = al.ArtistId
left join 
	music.tracks t
on 
	al.AlbumId = t.AlbumId
left join 
	music.genres g
on
	t.GenreId = g.GenreId
left join 
	music.playlist_track pt
on 
	pt.TrackId = t.TrackId
left join 
	music.playlists p
on p.PlaylistId = pt.PlaylistId
group by p.Name
order by [Number of artists] desc


```

5. Vilket är det genomsnittliga antalet artister per spellista?

```SQL
-- Answer
-- 61.18
SELECT 
    FORMAT(AVG(CAST([Unique artists] AS FLOAT)), '00.00') AS [Average unique artists per playlist]
FROM (
    SELECT
        p.PlaylistId,
        COUNT(DISTINCT a.ArtistID) AS [Unique artists]
    FROM
        music.playlists p
    LEFT JOIN music.playlist_track pt
        ON p.PlaylistId = pt.PlaylistId
    LEFT JOIN music.tracks t
        ON t.TrackId = pt.TrackId
    LEFT JOIN music.albums a
        ON t.AlbumId = a.AlbumId
    WHERE 
       p.Name NOT IN ('Music Videos', 'TV Shows', 'Movies', 'Audiobooks')
    GROUP BY
        p.PlaylistId
) AS Subquery;

```