//static void MyFunction()
//{
//    int[] myArray = new int[] { 4, 5, 1, 4 };

//    myArray[4] = 0;
//}


//try //Testar alltid överst först och ger felet på första felet som hittas.
//{
//    MyFunction();

//    Console.WriteLine("Det gick bra");
//}
//catch(Exception e) // Fångar error, kan dirigera
//{
//    Console.WriteLine($"Felet är detta: \n {e.Message}");
//}
//finally // Körs alltid
//{
//    Console.WriteLine("skrivs alltid ut");
//}

//Console.WriteLine("\n**********************************{n");


//try
//{
//    Int32.Parse("Hej");
//}
//catch (Exception e)
//{
//    Console.WriteLine($"Något hände {e.Message}");
//    throw;
//}



static int CalculateDiffToFuture(int futureYear)
{
    DateTime dt = DateTime.Now;
    int result = futureYear - dt.Year; ;
    
    if(futureYear < dt.Year)
    {
        throw new ArgumentOutOfRangeException();
    }
   
    return result;
}


try
{
    int futureYear = 2029;
    int year = CalculateDiffToFuture(futureYear);
    Console.WriteLine($"The year {futureYear} is {year} in the future.");
}
catch(ArgumentOutOfRangeException e)
{
    Console.WriteLine($"The year is not in the future! {e.Message}");
}