using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Observer
{
    internal class Subject: AbstractSubject<string>
    {
        public override void Notify(string value)
        {
            base.Notify(value);
        }
    }
}
