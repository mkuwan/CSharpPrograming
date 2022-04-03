using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Builder.BuilderPattern
{
    internal class ConcreteHouseBuilder : IHouseBuilder
    {
        private House _house = new House();

        public void Reset()
        {
            _house = new House();
        }

        public void Door(string kinds)
        {
            _house.Set("Door:= " + kinds);
        }

        public void Wall(string kinds)
        {
            _house.Set("Wall:= " + kinds);
        }

        public void Roof(string kinds)
        {
            _house.Set("Roof:= " + kinds);
        }

        public void Window(string kinds)
        {
            _house.Set("Window:= " + kinds);
        }

        public House GetHouse()
        {
            House result = this._house;

            this.Reset();

            return result;
        }
    }
}
