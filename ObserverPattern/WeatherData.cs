using System;
using System.Collections.Generic;

namespace ObserverPattern
{
	public class WeatherData :ISubject
	{
		private List<IObserver> observers;
		private float temperature;
		private float humidity;
		private float pressure;
		#region ISubject implementation

		public void registerObserver (IObserver o)
		{
			observers.Add (o);
		}

		public void removeObserver (IObserver o)
		{
			int i = observers.IndexOf (o);
			if(i>0){
				observers.RemoveAt (i);
			 
			}
		}

		public void notifyObserver ()
		{
			if(observers != null){
				foreach (var item in observers) {
					item.Update (this.temperature,this.humidity,this.pressure);
				}

			}
		}

		#endregion

		public WeatherData ()
		{
			observers = new List<IObserver> ();
		}

		public void GetTemperature(){

			//TODO
		}

		public void GetHumidity(){
			//TODO
		}

		public void Pressure(){
			//TODO
		}

		public void MeasurementsChanged(){
			notifyObserver ();
		}

		public void SetMeasuermentsChange(float temp,float humidity,float pressure){
			this.temperature = temp;
			this.humidity = humidity;
			this.pressure = pressure;
			notifyObserver ();
		}
	}
}

