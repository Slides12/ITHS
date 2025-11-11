namespace öv2.Classes
{
    public class WeatherService
    {
        private Dictionary<string, double> cities = new() { { "Stockholm", 90 } };

        public double GetWeatherInCity(string token,string city)
        {
            if(token == "yo-mama")
                return cities[city];

            return -999;
        }

    }
}
