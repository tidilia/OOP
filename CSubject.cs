using System;
using System.Collections.Generic;
using System.Text;
using laba07.Observer;

namespace laba07.Observer
{
    class CSubject
    {
		private List<CObserver> _observers;


		public CSubject()
		{
			// создаем пустой список наблюдателей - пока никто не наблюдает
			_observers = new List<CObserver>();
		}
		// метод для регистрации нового наблюдателя, с помощью которого наблюдатель
		// подписывается на уведомления о том, что наблюдаемый объект изменился
		public void addObserver(CObserver o)
		{
			_observers.Add(o);
		}
		// метод, который уведомляет всех подписанных наблюдателей о том, что что-то изменилось
		public void notifyEveryone()
		{
			// проходим по всем наблюдателям и вызываем у каждого его метод onSubjectChanged
			foreach (CObserver o in _observers)
				o.onSubjectChanged(this);
		}
	}
}
