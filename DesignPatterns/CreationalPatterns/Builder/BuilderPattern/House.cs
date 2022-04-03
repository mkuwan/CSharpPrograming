using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Builder.BuilderPattern
{
    internal class House
    {
        private List<object> _parts = new List<object>();

        public void Set(string part)
        {
            _parts.Add(part);
        }

        public string HouseVariations()
        {
            string variations = string.Empty;

            for (int i = 0; i < this._parts.Count; i++)
            {
                variations += this._parts[i].ToString() + "; ";
            }

            variations = variations.Remove(variations.Length - 2); // 最後の '; ' を削除

            return "Your House is: " + variations;
        }
    }
}
