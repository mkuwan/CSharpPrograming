using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Builder.BuilderPattern
{
    internal class Director
    {
        private IHouseBuilder _houseBuilder;
        
        public Director(IHouseBuilder houseBuilder)
        {
            _houseBuilder = houseBuilder;
        }

        public void BuildCasualHouse()
        {
            this._houseBuilder.Door("Color is Yellow");
            this._houseBuilder.Wall("made by wood");
            this._houseBuilder.Roof("Color is Green");
            this._houseBuilder.Window("by Stained glass");
        }

        public void BuildClassicalHouse()
        {
            this._houseBuilder.Door("made by wood");
            this._houseBuilder.Wall("Color is white");
            this._houseBuilder.Roof("flat roof");
            this._houseBuilder.Window("Square");
        }

        public void BuildShelterHouse()
        {
            this._houseBuilder.Door("to under ground");
            this._houseBuilder.Wall("made by Concrete and at least 30cm depth");
            this._houseBuilder.Roof("made by Concrete and at least 50cm depth");
            this._houseBuilder.Window("nothing");
        }
    }
}
