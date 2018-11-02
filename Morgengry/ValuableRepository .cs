using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class ValuableRepository : IPersistable
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

        public void Save(string v)
        {
            TextWriter tw = new StreamWriter(v, true);
            SaveMethod(tw);
            tw.Close();
        }

        public void Load(string v)
        {
            StreamReader sr = new StreamReader(v);
            LoadMethod(sr);
            sr.Close();
        }

        public void Save()
        {
            TextWriter tw = new StreamWriter("ValuableRepository.txt", true);
            SaveMethod(tw);
            tw.Close();
        }

        public void Load()
        {
            StreamReader sr = new StreamReader(@"ValuableRepository.txt");
            LoadMethod(sr);
            sr.Close();
        }

        public void SaveMethod(TextWriter tw)
        {
            for (int i = 0; i < valuables.Count; i++)
            {
                if (valuables[i] is Amulet)
                {
                    Amulet amulet = valuables[i] as Amulet;
                    tw.WriteLine($"AMULET;{amulet.ItemId};{amulet.Quality};{amulet.Design}");
                }
                else if (valuables[i] is Book)
                {
                    Book book = valuables[i] as Book;
                    tw.WriteLine($"BOG;{book.ItemId};{book.Title};{book.Price}");
                }
                else if (valuables[i] is Course)
                {
                    Course course = valuables[i] as Course;
                    tw.WriteLine($"KURSUS;{course.Name};{course.DurationInMinutes};{course.CourseHourValue}");
                }
            }
        }

        public void LoadMethod(StreamReader sr)
        {
            string line = null;
            while ((line = sr.ReadLine()) != null)
            {
                Amulet.Level amulet = Amulet.Level.low;
                string[] splitObject = line.Split(';');
                if (splitObject[0] == "AMULET")
                {
                    if (splitObject[2] == Amulet.Level.low.ToString())
                    {
                        amulet = Amulet.Level.low;
                    }
                    else if (splitObject[2] == Amulet.Level.medium.ToString())
                    {
                        amulet = Amulet.Level.medium;
                    }
                    else if (splitObject[2] == Amulet.Level.high.ToString())
                    {
                        amulet = Amulet.Level.high;
                    }
                    AddValuable(new Amulet(splitObject[1], amulet, splitObject[3]));
                }
                else if (splitObject[0] == "BOG")
                {
                    AddValuable(new Book(splitObject[1], splitObject[2], double.Parse(splitObject[3])));
                }
                else if (splitObject[0] == "KURSUS")
                {
                    AddValuable(new Course(splitObject[1], int.Parse(splitObject[2]), double.Parse(splitObject[3])));
                }
            }
        }
    }
}
