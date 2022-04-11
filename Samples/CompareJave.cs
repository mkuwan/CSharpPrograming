using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples
{
    public class CompareJava
    {
        public void ArraySample()
        {
            int[] a = { 1, 2, 3 };
            int[] b = new int[5];
            int[] c;
            c = new[] {3, 4, 5, 6, 7, 9};


            // この宣言はJavaだとエラーにならない
            //int err[];

        }

        internal class Item
        {
            public int price = 100;
        }

        public void ForArray()
        {
            Item[] items = new Item[3];
            int total = 0;

            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new Item(); // <- これがないと実行時エラーとなります　器だけ作っても、その中身(インスタンス)が格納される必要があります
                total += items[i].price;
            }

            Console.WriteLine(total);
        }

        public void HasNullArray()
        {
            string[] array = {"A", "B", "C", "D"};
            array[0] = null;

            foreach (var s in array)
            {
                Console.WriteLine(s); //C#だとnullはなにも表示されませんが、Javaだとnullと文字で表示されます
            }
        }

        public void Arrange()
        {
            int[] a = new int[2] {2, 3}; //C#だといけるけど、Javaだとコンパイルエラーとなります

            string[][] array =  {new string[] {"A", "B"}, null,  new string[] {"C", "D", "E"}}; // Javaだと実行時エラー NullPointerExceptionが発生します

            string[][] arrayB = { new string[] { "A", "B" }, new string[] { "あ", "い" }, new string[] { "1", "2", "3" } };

            //var s = "2021-08-09";
            //var fs = String.Format("yyyy/MM/dd", s);
        }
    }
}
