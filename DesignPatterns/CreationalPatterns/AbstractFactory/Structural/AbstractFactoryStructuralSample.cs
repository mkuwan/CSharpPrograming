using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Structural
{
    /// <summary>
    /// この例ではInterfaceでコードを書いていますが、内部でのメソッドがないのでほとんどすべてをabstractに入れ替えても同じです
    ///
    /// 抽象化はインターフェースでの実装が一つの例ですが、最近では拡張メソッドのほうが共通処理には向いているかもしれません
    /// LinQがその良い例(LinQのために拡張メソッドが作られたともされている)
    /// </summary>
    internal class AbstractFactoryStructuralSample
    {
        public void Run()
        {
            // Abstract factory #1
            IAbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run();

            // Abstract factory #2
            IAbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();

        }
    }
}
