using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolHierarchy;

namespace TestSchool
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentIdOutOfRangeTest()
        {
            Student zlatko = new Student("Zlati", 9999); 
        }
    }
}
