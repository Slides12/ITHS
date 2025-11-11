namespace öv2.Classes
{
    public class TempConverter
    {
        public double ConvertFromFtoC(double fahrenheit)
        {
            double c = (fahrenheit - 32) * 5 / 9;

            return c ;
        }
    }
}
