using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Observer
{
    internal abstract class AbstractSubject<T>: IObservable<T>
    {
        private readonly List<IObserver<T>> _observers = new List<IObserver<T>>();

        public IDisposable Subscribe(IObserver<T> observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);

            return new UnSubscriber<T>(_observers, observer);
        }

        public void Unsubscribe(IObserver<T> observer)
        {
            if (_observers.Contains(observer))
                _observers.Remove(observer);
        }

        public virtual void Notify(T value)
        {
            foreach (var observer in _observers)
            {
                observer.OnNext(value);
            }
        }
    }

    /// <summary>
    /// 購読解除用IDisposable実装
    /// </summary>
    internal class UnSubscriber<T> : IDisposable
    {
        private List<IObserver<T>>? _observers;
        private IObserver<T>? _observer;

        internal UnSubscriber(List<IObserver<T>> observers, IObserver<T> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observer == null) return;

            if (_observers?.IndexOf(_observer) != -1)
                _observers?.Remove(_observer);

            _observers = null;
            _observer = null;
        }
    }
}
