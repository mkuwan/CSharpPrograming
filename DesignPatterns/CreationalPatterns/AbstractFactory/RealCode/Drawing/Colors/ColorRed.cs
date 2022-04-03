using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.RealCode.Drawing.Colors
{
    internal class ColorRed : IColor
    {
        public string SelectColor() => "Red";
    }
}
