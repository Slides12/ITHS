# SQL with c#
(Download nuget Microsoft.Data.SqlClient)


(using Microsoft.Data.SqlClient;)

### Connect to Sql server / database
https://www.connectionstrings.com/sql-server/
```C#
using Microsoft.Data.SqlClient;

var connectionString = "Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;";


using (var connection = new SqlConnection(connectionString))
{
    connection.Open();
}
```

* Connection string is different depending on which type of server you connect to.

* Add "TrustServerCertificate = True;" to access data base without certificate.
```C#
var connectionString = "Server=localhost;Database=everyloop;Trusted_Connection=True;TrustServerCertificate = True;";
```

* add a using SQLcommand to get data from server. 
```C#
using Microsoft.Data.SqlClient;

var connectionString = "Server=localhost;Database=everyloop;Trusted_Connection=True;TrustServerCertificate = True;";
var query = "select * from users;";

using (var connection = new SqlConnection(connectionString))
using (var command = new SqlCommand(query,connection))
{
    connection.Open();

    using (var reader = command.ExecuteReader())
    {

    }
}
```


* To get the name of the columns in the database 
```C#
using (var command = new SqlCommand(query,connection))
{
    connection.Open();

    using (var reader = command.ExecuteReader())
    {
        for(int i = 0; i < reader.FieldCount; i++)
        {
            Console.WriteLine($"{reader.GetName(i)}");
        }
    }
}
```

* If you want which type the database is use: GetFieldType
```C#
Console.WriteLine($"{reader.GetName(i)} {reader.GetFieldType(i)}");
```

* To get the type of the database in SQL format, use: GetDataTypeName
```C#
            Console.WriteLine($"{reader.GetName(i), -20} {reader.GetFieldType(i)} {reader.GetDataTypeName(i)}");

```

* Using a while loop you can use the code below:
```C#
        while(reader.Read())
        {

        }
```


* Get the values from each column using index: 
```C#
  while(reader.Read())
  {
      Console.WriteLine(reader.GetValue(2));
  }
  ``` 


  * Get all the values in all the columns: GetValue(index)
  ```C#
          while(reader.Read())
        {
            for(int i = 0; i < reader.FieldCount; i++)
            {
                Console.Write($"{reader.GetValue(i)}, ");

            }
            Console.WriteLine();
        }
```


