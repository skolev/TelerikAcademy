using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolHierarchy
{
    public class Course : IEquatable<Course>
    {
        private const int COURSE_MAX_STUDENTS = 30;
        private string courseName;
        private List<Student> courseStudents = new List<Student>();

        public Course(string course)
        {
            this.CourseName = course;
        }

        public List<Student> CourseStudents
        {
            get
            {
                return this.courseStudents;
            }
        }

        public string CourseName
        {
            get
            {
                return this.courseName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Course must have a name!");
                }

                this.courseName = value;
            }
        }

        public void AddStudent(Student student)
        {
            if (this.courseStudents.Count == COURSE_MAX_STUDENTS)
            {
                throw new ArgumentOutOfRangeException("The course is full " + this.courseStudents.Count + "/" + COURSE_MAX_STUDENTS);
            }

            if (this.courseStudents.Contains(student))
            {
                throw new ArgumentException("Student is already signed for this course");
            }

            this.courseStudents.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (this.courseStudents.Contains(student))
            {
                this.courseStudents.Remove(student);
            }
            else
            {
                throw new ArgumentException("This student is not in that course");
            }
        }

        public bool Equals(Course other)
        {
            if (this.CourseName == other.CourseName)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
