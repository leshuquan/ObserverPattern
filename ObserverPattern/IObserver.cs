using System;

namespace ObserverPattern
{
	
	public interface IObserver	//观察者接口
	{
		void Update (float temp, float humidity, float pressure);
	}

}

