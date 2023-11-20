using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationDemoWeek10Fall2023
{
    public class Location
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public string ImagePath { get; set; }


        public Item Item { get; set; }

        public NPC NPC { get; set; }

    }
}
