using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionProject.MethodBase
{
    internal class ConstructorInfoSample
    {
        private string _field = "フィールド";

        public string Property { get; set; } = "プロパティ";

        public ConstructorInfoSample() { }

        public ConstructorInfoSample(string value)
        {
            _field += value;
            Property += value;
        }

        public void NoArgumentMethod()
        {
            Console.WriteLine(_field);
        }

        public void ArgumentMethod(string value)
        {
            _field += value;
            Console.WriteLine(_field);
        }
    }

    

    }

}
