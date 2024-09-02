static string BindeStreck(string text)
{

    string output = string.Join("-", text.ToCharArray());

    return output;
}

BindeStreck("hejsan svejsan");

Console.WriteLine(BindeStreck("hejsan svejsan"));