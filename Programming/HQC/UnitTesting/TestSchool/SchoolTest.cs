using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolHierarchy;

namespace TestSchool
{
    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NamelessSchoolTest()
        {
            School school = new School("Vasil Levski");
            school.SchoolName = string.Empty;
        }

        [TestMethod]
        public void AddCourseTest()
        {
            School school = new School("Vasil Levski");
            Course math = new Course("Mathematics");
            school.AddCourse(math);
            Course history = new Course("History");
            school.AddCourse(history);
            Assert.AreEqual(2, school.Courses.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddCourseTwiceTest()
        {
            School school = new School("Vasil Levski");
            Course math = new Course("Mathematics");
            school.AddCourse(math);
            school.AddCourse(math);
        }

        [TestMethod]
        public void AddStudentTest()
        {
            School school = new School("Vasil Levski");
            Student pepi = new Student("Pesho", 10001);
            school.AddStudent(pepi);
            Assert.AreEqual(1, school.Students.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddStudentTestTwice()
        {
            School school = new School("Vasil Levski");
            Student pepi = new Student("Pesho", 10001);
            school.AddStudent(pepi);
            school.AddStudent(pepi);
        }

        [TestMethod]
        public void RemoveStudent()
        {
            School school = new School("Vasil Levski");
            Student pepi = new Student("Pesho", 10001);
            school.AddStudent(pepi);
            school.RemoveStudent(pepi);
            Assert.AreEqual(0, school.Students.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveStudentTwice()
        {
            School school = new School("Vasil Levski");
            Student pepi = new Student("Pesho", 10001);
            school.AddStudent(pepi);
            school.RemoveStudent(pepi);
            school.RemoveStudent(pepi);
        }
    }
}
