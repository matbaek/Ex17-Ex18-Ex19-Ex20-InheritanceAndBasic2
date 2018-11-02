using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Morgengry;
using static Morgengry.Amulet;

namespace Test
{
    [TestClass]
    public class UnitTest2
    {
        //Book b1, b2, b3;
        //Amulet a11, a12, a13;
        //Course c111, c112;

        //CourseRepository courses = new CourseRepository();
        //MerchandiseRepository merchandises = new MerchandiseRepository();


        //[TestInitialize]
        //public void Init()
        //{
        //    b1 = new Book("1");
        //    b2 = new Book("2", "Falling in Love with Yourself");
        //    b3 = new Book("3", "Spirits in the Night", 123.55);
        //    merchandises.AddMerchandise(b1);
        //    merchandises.AddMerchandise(b2);
        //    merchandises.AddMerchandise(b3);

        //    a11 = new Amulet("11");
        //    a12 = new Amulet("12", Level.high);
        //    a13 = new Amulet("13", Level.low, "Capricorn");
        //    merchandises.AddMerchandise(a11);
        //    merchandises.AddMerchandise(a12);
        //    merchandises.AddMerchandise(a13);


        //    c111 = new Course("Eufori med røg");
        //    c112 = new Course("Nuru Massage using Chia Oil", 157);
        //    courses.AddCourse(c111);
        //    courses.AddCourse(c112);

        //}

        //[TestMethod]
        //public void TestGetValueForBook()
        //{
        //    Assert.AreEqual(0.0, Utility.GetValueOfMerchandise(b1));
        //    Assert.AreEqual(0.0, Utility.GetValueOfMerchandise(b2));
        //    Assert.AreEqual(123.55, Utility.GetValueOfMerchandise(b3));
        //    Assert.AreEqual(183.55, merchandises.GetTotalValue());
        //}

        //[TestMethod]
        //public void TestGetValueForAmulet()
        //{
        //    Assert.AreEqual(20.0, Utility.GetValueOfMerchandise(a11));
        //    Assert.AreEqual(27.5, Utility.GetValueOfMerchandise(a12));
        //    Assert.AreEqual(12.5, Utility.GetValueOfMerchandise(a13));
        //    Assert.AreEqual(183.55, merchandises.GetTotalValue());
        //}

        //[TestMethod]
        //public void TestGetValueForCourse()
        //{
        //    Assert.AreEqual(0.0, Utility.GetValueOfCourse(c111));
        //    Assert.AreEqual(2625.00, Utility.GetValueOfCourse(c112));
        //    Assert.AreEqual(2625.00, merchandises.GetTotalValue());
        //}
    }

}
