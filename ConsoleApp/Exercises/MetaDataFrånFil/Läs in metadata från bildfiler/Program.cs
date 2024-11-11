using (FileStream stream = File.OpenRead("C:\\Users\\djoha\\Desktop\\TestBilder\\3.bmp"))
{
    byte[] data = new byte[stream.Length];
    int width = 0;
    int height = 0;



    stream.Read(data);


        //Console.Write(data[i].ToString("X2") + " ");
        if (data[0].ToString("X2") == "42")
        {
            if (data[1].ToString("X2") == "4D")
            {
                width = data[18] + (data[19] * 256) + (data[20] * 256 * 256) + (data[21] * 256 * 256 * 256);
                height = data[22] + (data[23] * 256) + (data[24] * 256 * 256) + (data[25] * 256 * 256 * 256);
                Console.WriteLine($"This is s .bmp File. Resolution: {width} x {height} ");

            }
        }
        else if (data[0].ToString("X2") == "89")
        {
            if (data[1].ToString("X2") == "50")
            {
                width = Convert.ToInt32(data[18].ToString("X") + data[19].ToString("X"), 16);
                height = Convert.ToInt32(data[22].ToString("X") + data[23].ToString("X"), 16);
            Console.WriteLine($"This is s .png File. Resolution: {width} x {height} ");
            }
        }


}