using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Structural
{
    internal class ProductsA1: IAbstractProductA
    {
        public void MethodA()
        {
            Console.WriteLine("ProductsA1: IAbstractProductA");
        }
    }
    internal class ProductsA2 : IAbstractProductA
    {
        public void MethodA()
        {
            Console.WriteLine("ProductsA2: IAbstractProductA");
        }
    }

    internal class ProductsB1: IAbstractProductB
    {
        public void MethodB()
        {
            Console.WriteLine("ProductsB1: IAbstractProductB");
        }
    }
    internal class ProductsB2 : IAbstractProductB
    {
        public void MethodB()
        {
            Console.WriteLine("ProductsB2: IAbstractProductB");
        }
    }
}
