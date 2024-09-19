Hejsan hej = new Hejsan();

hej.Blue = 55.0;
hej.Red = 99.0;


Console.WriteLine($"Red = {hej.Red} Blue = {hej.Blue}");



class Hejsan
{
    private double _red;
    private double _blue;



    public double Red { 
        get { return _red; }
        set
        {
            if (value < 100)
            {
                _red = value;
                _blue = 100 - _red;

            }
            else
            {
                Console.WriteLine("Value should be between 0 and 100");
            }
        }
    }
    public double Blue
    {
        get { return _blue; }
        set {
            if (value < 100)
            {
                _blue = value;
                _red = 100 - _blue;

            }
            else
            {
                Console.WriteLine("Value should be between 0 and 100");

            }
        }
    }

}