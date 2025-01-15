-- select * from generate_series(1,5);

-- alter database everyloop set compatibility_level = 160;

-- select * from string_split('detta är ett exempel på en string split', ' ');




declare @json nvarchar(max) = (select * from openrowset(BULK 'C:\orderdata.json', SINGLE_CLOB) as import)



-- print(@json)


select * from openjson(@json) with (
    Id int,
    Customer NVARCHAR(20),
    FirstProduct NVARCHAR(100) '$.Product[0].ProductName',
    OrderDate datetime2 '$.Timestamps.OrderDate',
    ShippedDate DATETIME2 '$.Timestamps.ShippedDate'
    --Timestamps nvarchar(max) as json
);




