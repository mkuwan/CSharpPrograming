using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Observer
{
    internal class Observer: IObserver<string>
    {
        private readonly string _name;

        public Observer(string name)
        {
            _name = name;
        }

        public void OnCompleted()
        {
            Console.WriteLine("Observer OnCompleted");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"Observer OnError: {error.Message}");
        }

        public void OnNext(string value)
        {
            Console.WriteLine($"Observer OnNext at {_name}: {value}");
        }
    }
}
