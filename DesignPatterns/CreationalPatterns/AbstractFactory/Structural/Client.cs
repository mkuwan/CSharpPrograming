using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Structural
{
    internal class Client
    {
        private readonly IAbstractProductA _abstractProductA;
        private readonly IAbstractProductB _abstractProductB;

        public Client(IAbstractFactory factory)
        {
            _abstractProductA = factory.CreateProductA();
            _abstractProductB = factory.CreateProductB();
        }

        public void Run()
        {
            _abstractProductA.MethodA();
            _abstractProductB.MethodB();
        }
    }
}
