using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Builder.BuilderPattern
{
    internal interface IHouseBuilder
    {
        void Reset();

        void Door(string kinds);

        void Wall(string kinds);

        void Roof(string kinds);

        void Window(string kinds);
    }
}
