using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolHierarchy;

namespace TestSchool
{
    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NamelessSchoolTest()
        {
            Course historyCourse = new Course("History 101");
            historyCourse.CourseName = string.Empty;
        }

        [TestMethod]
        public void AddStudentTest()
        {
            Course historyCourse = new Course("History 101");
            Student gosho = new Student("Jorko", 10002);
            historyCourse.AddStudent(gosho);
            Student didko = new Student("Dido", 10003);
            historyCourse.AddStudent(didko);
            Assert.AreEqual(2, historyCourse.CourseStudents.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddStudentTwiceTest()
        {
            Course historyCourse = new Course("History 101");
            Student gosho = new Student("Jorko", 10002);
            historyCourse.AddStudent(gosho);
            historyCourse.AddStudent(gosho);
        }

        [TestMethod]
        public void RemoveStudentTest()
        {
            Course historyCourse = new Course("History 101");
            Student gosho = new Student("Jorko", 10002);
            historyCourse.AddStudent(gosho);
            historyCourse.RemoveStudent(gosho);
            Assert.AreEqual(0, historyCourse.CourseStudents.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveStudentTwiceTest()
        {
            Course historyCourse = new Course("History 101");
            Student gosho = new Student("Jorko", 10002);
            historyCourse.AddStudent(gosho);
            historyCourse.RemoveStudent(gosho);
            historyCourse.RemoveStudent(gosho);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MaxCourseStudentsTest()
        {
            Course historyCourse = new Course("History 101");
            int uniqueId = 10000;
            StringBuilder student = new StringBuilder();
            student.Append("Jorko");
            for (int i = 0; i < 31; i++)
            {
                student.Append(i);
                Student gosho = new Student(student.ToString(), uniqueId);
                historyCourse.AddStudent(gosho);
                student.Length--;
                uniqueId++;
            }
        }
    }
}
