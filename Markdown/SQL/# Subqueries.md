# Subqueries

```SQL
select subquery.Name
from 
(select 
	concat(FirstName, ' ' , LastName) as Name,
	email,
	phone
from
	users
where FirstName like '[a-d]%'
) subquery
where len(name) > 15
```

```SQL
select
TrackId,
Name,
AlbumId,
(select Title from music.albums where AlbumId = t.AlbumId)
from
music.tracks as t
```