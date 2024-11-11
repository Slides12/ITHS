static bool Length(string sträng, int heltal)
{
    if(sträng.Length > heltal)
    {
        return true;
    }
    else
    {
        return false;

    }
}


Console.WriteLine(Length("HallåEller", 1));