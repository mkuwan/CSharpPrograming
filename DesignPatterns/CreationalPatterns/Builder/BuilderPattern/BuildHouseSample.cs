using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Builder.BuilderPattern
{
    internal class BuildHouseSample
    {
        public void Run()
        {
            var builder = new ConcreteHouseBuilder();
            var director = new Director(builder);

            Console.WriteLine("Build Casual House");
            director.BuildCasualHouse();
            Console.WriteLine(builder.GetHouse().HouseVariations());

            Console.WriteLine("Build Classical House");
            director.BuildClassicalHouse();
            Console.WriteLine(builder.GetHouse().HouseVariations());

            Console.WriteLine("Build Shelter House");
            director.BuildShelterHouse();
            Console.WriteLine(builder.GetHouse().HouseVariations());
        }
    }
}
