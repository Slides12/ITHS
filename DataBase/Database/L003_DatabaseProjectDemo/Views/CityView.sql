CREATE VIEW [dbo].[CityData] as
select 
	[ci].[Id], 
	[ci].[CityName] as 'City', 
	[ci].[CountryID], 
	[co].[CityName] as 'Country'
from 
	Cities as ci
left join Cities as co
on co.id = ci.CountryID
