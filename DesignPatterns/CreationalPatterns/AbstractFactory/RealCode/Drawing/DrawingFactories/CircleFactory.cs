using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.CreationalPatterns.AbstractFactory.RealCode.Drawing.Colors;
using DesignPatterns.CreationalPatterns.AbstractFactory.RealCode.Drawing.Shapes;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.RealCode.Drawing.DrawingFactories
{
    internal class CircleFactory : IDrawingFactory
    {
        private static int _countInstance = 0;

        public CircleFactory()
        {
            _countInstance++;
        }

        public IColor SetColor()
        {
            var selector = _countInstance % 3;

            switch (selector)
            {
                case 0:
                    return new ColorGreen();
                case 1:
                    return new ColorRed();
                case 2:
                    return new ColorYellow();
                default:
                    throw new ArgumentOutOfRangeException(nameof(selector), "指定範囲外");
            }

            // Switch式にするとこうなる
            //return selector switch
            //{
            //    0 => new ColorGreen(),
            //    1 => new ColorRed(),
            //    2 => new ColorYellow(),
            //    _ => throw new ArgumentOutOfRangeException(nameof(selector), "指定範囲外")
            //};
        }

        public IShape SetShape()
        {
            return new ShapeCircle();
        }
    }
}
