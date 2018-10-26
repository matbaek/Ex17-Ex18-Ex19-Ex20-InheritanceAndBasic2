using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Amulet : Merchandise
    {
        Level quality;
        string design = "";
        
        public Level Quality
        {
            get { return quality; }
            set { quality = value; }
        }
        public string Design
        {
            get { return design; }
            set { design = value; }
        }

        public enum Level
        {
            low,
            medium,
            high
        }

        public Amulet(string itemId, Level quality, string design)
        {
            ItemId = itemId;
            Quality = quality;
            Design = design;
        }

        public Amulet(string itemId, Level quality) : this(itemId, quality, "") { }

        public Amulet(string itemId) : this(itemId, Level.medium) { }

        public Amulet() { }

        override
        public string ToString()
        {
            string result = null;

            result += "ItemId: " + ItemId + ", ";
            result += "Quality: " + quality + ", ";
            result += "Design: " + design;

            return result;
        }
    }
}
