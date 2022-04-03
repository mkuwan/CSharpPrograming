using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Structural
{
    internal class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ProductsA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ProductsB1();
        }
    }

    internal class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ProductsA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ProductsB2();
        }
    }
}
