using System;

namespace ObserverPattern
{
	public class CurrentConditionsDisplay :IObserver,IDisplayElement
	{
		private float temp;
		private float humidity;
		private float pressure;

		private ISubject subject;
		#region IObserver implementation

		public void Update (float temp, float humidity, float pressure)
		{
			this.temp = temp;
			this.humidity = humidity;
			this.pressure = pressure;
			Display ();
		}

		#endregion

		#region IDisplayElement implementation

		public void Display ()
		{
			//显示点什么
			Console.WriteLine (string.Format("I'm CurrentDisplay!temp={0},humidity={1},pressure={2}",temp,humidity,pressure));
		}

		#endregion


		public CurrentConditionsDisplay (ISubject subject)
		{
			this.subject = subject;
			subject.registerObserver (this);
		}
	}
}

