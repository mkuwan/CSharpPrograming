using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Observer
{
    internal class ObserverSample
    {
        public void Run()
        {
            var subject = new Subject();

            var observerA = new Observer("A");
            var observerB = new Observer("B");

            var disposableA = subject.Subscribe(observerA);
            var disposableB = subject.Subscribe(observerB);

            subject.Notify("2 observers A and B");

            // Unsubscribe / Dispose　どちらかでOKです
            subject.Unsubscribe(observerA);
            disposableA.Dispose();

            subject.Notify("observer B only");
            disposableB.Dispose();
            
            subject.Notify("B disposed");
        }
    }
}
