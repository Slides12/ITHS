static string MyJoin(string character, params string[] text)
{
    string word = "";
    for(int i = 0; i < text.Length; i++)
    {
        word += text[i];
        if(i != text.Length - 1) { 
            word += character;
        }
    }
    return word;
}

MyJoin("->", "Sverige", "Norge", "Finland");
Console.WriteLine(MyJoin("->", "Sverige", "Norge", "Finland", "Spanien"));