using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.CreationalPatterns.AbstractFactory.RealCode.Drawing.DrawingFactories;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.RealCode.Drawing
{
    internal class AbstractFactoryCodeSample
    {
        public void Run()
        {
            Writer writer = new Writer(new CircleFactory());
            writer.Writing();
        }


    }
}
