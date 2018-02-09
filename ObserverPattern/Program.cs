using System;

namespace ObserverPattern
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			ISubject weatherData = new WeatherData ();
			CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay (weatherData);

			weatherData.SetMeasuermentsChange (37,90,12);
		}
	}
}
