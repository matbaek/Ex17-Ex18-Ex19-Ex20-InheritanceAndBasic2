using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class ValuableRepository
    {
        private List<IValuable> valuables = new List<IValuable>();

        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }

        public IValuable GetValuable(string id)
        {
            for (int i = 0; i < valuables.Count; i++)
            {
                if (valuables[i] is Amulet)
                {
                    Amulet amulet = valuables[i] as Amulet;
                    if (amulet.ItemId == id)
                    {
                        return amulet;
                    }
                }
                else if (valuables[i] is Book)
                {
                    Book book = valuables[i] as Book;
                    if (book.ItemId == id)
                    {
                        return book;
                    }
                }
                else if (valuables[i] is Course)
                {
                    Course course = valuables[i] as Course;
                    if (course.Name == id)
                    {
                        return course;
                    }
                }

            }
            return null;
        }

        public double GetTotalValue()
        {
            double totalValue = 0;

            for (int i = 0; i < valuables.Count; i++)
            {
                totalValue += valuables[i].GetValue();
            }

            return totalValue;
        }

        public int Count()
        {
            return valuables.Count;
        }
    }
}
