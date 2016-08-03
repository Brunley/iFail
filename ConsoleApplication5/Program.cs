using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {

            var factory = new GatheringFactory();
            var materials = factory.GetMaterialsListing();
            var cities = factory.GetCityListing();
            foreach(var material in materials)
            {
                foreach(var city in cities)
                {
                    var total = factory.Find(material, city);
                        
                }
            }


            Console.WriteLine();
            Console.ReadLine();



        }
    }
}
