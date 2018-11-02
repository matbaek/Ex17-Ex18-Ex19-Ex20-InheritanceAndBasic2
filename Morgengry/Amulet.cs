using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Amulet : Merchandise
    {
        public string design = "";
        Level quality;
        private double lowQualityValue = 0;
        private double mediumQualityValue = 0;
        private double highQualityValue = 0;

        public string Design
        {
            get { return design; }
            set { design = value; }
        }
        public Level Quality
        {
            get { return quality; }
            set { quality = value; }
        }
        public double LowQualityValue
        {
            get { return lowQualityValue; }
            set { lowQualityValue = value; }
        }
        public double MediumQualityValue
        {
            get { return mediumQualityValue; }
            set { mediumQualityValue = value; }
        }
        public double HighQualityValue
        {
            get { return highQualityValue; }
            set { highQualityValue = value; }
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

        
        public override string ToString()
        {
            string result = null;

            result += "ItemId: " + ItemId + ", ";
            result += "Quality: " + quality + ", ";
            result += "Design: " + design;

            return result;
        }

        public override double GetValue()
        {
            if (Quality == Level.low)
            {
                return 12.5;
            }
            else if (Quality == Level.medium)
            {
                return 20.0;
            }
            else
            {
                return 27.5;
            }
        }   
    }
}
