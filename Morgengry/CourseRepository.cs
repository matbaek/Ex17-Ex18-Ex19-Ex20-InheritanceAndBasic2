using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class CourseRepository
    {
        private List<Course> courses = new List<Course>();

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public Course GetCourse(string itemId)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].ItemId == itemId)
                {
                    return courses[i];
                }

            }
            return null;
        }

        public double GetTotalValue()
        {
            double totalValue = 0;

            for (int i = 0; i < courses.Count; i++)
            {
                totalValue += Utility.GetValueOfCourse(courses[i]);
            }

            return totalValue;
        }
    }
}
