using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class AmuletRepository
    {
        private List<Amulet> amulets = new List<Amulet>();

        public void AddAmulet(Amulet amulet)
        {
            amulets.Add(amulet);
        }

        public Amulet GetAmulet(string itemId)
        {
            for (int i = 0; i < amulets.Count; i++)
            {
                if (amulets[i].ItemId == itemId)
                {
                    return amulets[i];
                }

            }
            return null;
        }

        public double GetTotalValue()
        {
            double totalValue = 0;

            for (int i = 0; i < amulets.Count; i++)
            {
                totalValue += Utility.GetValueOfAmulet(amulets[i]);
            }

            return totalValue;
        }
    }
}
