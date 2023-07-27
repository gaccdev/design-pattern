
using Observer;

var weatherData = new WeatherData();

var currentDisplay = new CurrentMeasurementDisplay(weatherData);
var statisticsDisplay = new StatisticsMeasurementDisplay(weatherData);
var foreCastDisplay = new ForeCastMeasurementDisplay(weatherData);

Console.WriteLine("--------------------------");
weatherData.SetMeasurements(50, 50, 50);
Console.WriteLine("--------------------------");
weatherData.SetMeasurements(50, 10, 20);
Console.WriteLine("--------------------------");
weatherData.SetMeasurements(30, 50, 10);
Console.WriteLine("--------------------------");


Console.Read();