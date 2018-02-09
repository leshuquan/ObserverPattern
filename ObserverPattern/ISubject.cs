using System;

namespace ObserverPattern
{
	public interface ISubject
	{
		void registerObserver(IObserver o);	//面对接口编程,而不是面对实现编程
		void removeObserver (IObserver o);
		void notifyObserver();
		void SetMeasuermentsChange (float temp, float humidity, float pressure);

	}
}

