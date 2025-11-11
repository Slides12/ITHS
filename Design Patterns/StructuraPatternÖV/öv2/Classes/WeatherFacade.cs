namespace öv2.Classes
{
    public class WeatherFacade
    {
        private readonly TempConverter _converter;
        private readonly WeatherService _weatherService;
        private readonly WeatherAuth _weatherAuth;

        public WeatherFacade(TempConverter converter, WeatherService weatherService, WeatherAuth weatherAuth)
        {
            _converter = converter;
            _weatherService = weatherService;
            _weatherAuth = weatherAuth;
        }

        public string GetCurrentTemperature(string city)
        {
            return $"The weather in {city} is currently {_converter.ConvertFromFtoC(_weatherService.GetWeatherInCity(_weatherAuth.GetToken(), city))} Celsius.";
        }
    }
}
