using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    public class GatheringFactory
    {

        public IList<Material> GetMaterialsListing()
        {
            return new List<Material>
            {
            new Material {Name = "Copper", Rate = 1 },
            new Material { Name = "Iron", Rate = 2 },
            new Material {Name = "Steel", Rate = 3 },
            new Material {Name = "Silver", Rate = 4 },
            new Material {Name = "Crysteel", Rate = 5 },
            new Material {Name = "Gold", Rate = 6 },
            new Material {Name = "Titanium", Rate = 7 },
            new Material {Name = "Mithril", Rate = 8 },
            new Material {Name = "Obsidian", Rate = 9 },
            new Material {Name = "Adamant", Rate = 10 },
            new Material {Name = "Burlap", Rate = 11 },
            new Material {Name = "Cloth" , Rate = 12},
            new Material {Name = "Linen", Rate = 13 },
            new Material {Name = "Leather" , Rate = 14 },
            new Material {Name = "Fur", Rate = 15 },
            new Material {Name = "Silk", Rate = 16 },
            new Material {Name = "Silverweave", Rate = 17 },
            new Material {Name = "Sunsilk", Rate = 18 },
            new Material {Name = "Moonsilk", Rate = 19 },
            new Material {Name = "Bloodthread", Rate = 20 },
            new Material {Name = "Dragon Cloth", Rate = 21 },
            new Material {Name = "Sparkling Dust", Rate = 22 },
            new Material {Name = "Powder Dust", Rate = 23 },
            new Material {Name = "Glowing Dust", Rate = 24 },
            new Material {Name = "Crystal Dust", Rate = 25 },
            new Material {Name = "Silver Dust", Rate = 26 },
            new Material {Name = "Spirit Gem", Rate = 27 },
            new Material {Name = "Warlock Stone", Rate = 28 },
            new Material {Name = "Darkshard", Rate = 29 },
            new Material {Name = "Soul Gem", Rate = 30 },
            new Material {Name = "Blood Diamond", Rate = 31 },
            new Material {Name = "Platinum", Rate = 32 },
            new Material {Name = "Rose Petals", Rate = 33 },
            new Material {Name = "Muckmud", Rate = 34 },
            new Material {Name = "Azure Bark", Rate = 35 },
            new Material {Name = "Manaray Tail", Rate = 36 },
            new Material {Name = "Ox Heart", Rate = 37 },
            new Material {Name = "Wisper Thorax", Rate = 38 },
            new Material {Name = "Sliver of Fjord Ice", Rate = 39 },
            new Material {Name = "Hot Toad Flesh", Rate = 40 },
            new Material {Name = "Troll Meat", Rate = 41 },
            new Material {Name = "Nightshade", Rate = 42 },
            new Material {Name = "Crushed Butcher Briar Leaf", Rate = 43 },
            new Material {Name = "Leather Scraps", Rate = 44 },
            new Material {Name = "Tumpbeast Hide", Rate = 45 },
            new Material {Name = "Va'kaar Scales", Rate = 46 },
            new Material {Name =  "Marbeast Leather", Rate = 47 },
            new Material {Name = "Bristleboar Leather", Rate = 48 },
            new Material {Name = "Zumming Bird Flesh", Rate = 49 },
            new Material {Name = "Dire Fur", Rate = 50 },
            new Material {Name = "Grove Hair Fur", Rate = 51 },
            new Material {Name = "Salamander Leathers", Rate = 52 },
            new Material {Name = "Skyterror Scales", Rate = 53 }
            };
        }

        public IList<City> GetCityListing()
        {
            return new List<City>
        {
            new City { Name = "Darkthorn" },
            new City { Name = "Lightrose" },
            new City { Name = "Cromwell" },
            new City { Name = "Journey" },
            new City { Name = "Glym'nar" },
            new City { Name = "Blue Mesa" }


        };
        }

        public int UnitsFound(Material material, City city, int possible)
        {
            foreach (int UnitsPossible ) 
            {
                if (new Irregular().Next(1, 100) > material.Rate  )
                { return 1; }
                else
                { return 0; }
            }


        }

        public int UnitsPossible( Material material, City city)
        {
            return new Irregular().Next(1, 24);

            for (int = 0, i < possible; i++) { }


        }

        public int UnitsLost (Material material, City city, int found)
        {
            return 0;
        }
            
                   
        

    }
}
