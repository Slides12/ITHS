using öv2.Classes;

var TempConverter = new TempConverter();
var WeatherService = new WeatherService();
var WeatherAuth = new WeatherAuth();

var facade = new WeatherFacade(TempConverter, WeatherService, WeatherAuth);
Console.WriteLine(facade.GetCurrentTemperature("Stockholm"));
