using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry 
{
    public class Course : IValuable
    {
        private string name = "";
        private int durationInMinutes = 0;
        private double courseHourValue = 825;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int DurationInMinutes
        {
            get { return durationInMinutes; }
            set { durationInMinutes = value; }
        }
        public double CourseHourValue
        {
            get { return courseHourValue; }
            set { courseHourValue = value; }
        }

        public Course(string name, int durationInMinutes)
        {
            Name = name;
            DurationInMinutes = durationInMinutes;
        }

        public Course(string name) : this(name, 0) { }

        public Course() { }


        override
        public string ToString()
        {
            string result = null;
            
            result += "Name: " + name + ", ";
            result += "Duration in Minutes: " + durationInMinutes + ", ";
            result += "Pris pr påbegyndt time: " + courseHourValue;

            return result;
        }

        public double GetValue()
        {
            double hours = 0;

            for (int i = 0; i < durationInMinutes; i += 60)
            {
                hours++;
            }

            return hours * CourseHourValue;
        }
    }
}
