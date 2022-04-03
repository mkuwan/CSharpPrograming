using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.CreationalPatterns.AbstractFactory.RealCode.Drawing;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.RealCode
{
    internal class Writer
    {
        private readonly IColor _color;
        private readonly IShape _shape;

        public Writer(IDrawingFactory drawingFactory)
        {
            _color = drawingFactory.SetColor();
            _shape = drawingFactory.SetShape();
        }

        public void Writing()
        {
            var color = _color.SelectColor();
            var shape = _shape.SelectShape();

            Console.WriteLine($"Color is {color}, Shape is {shape}");
        }
    }
}
