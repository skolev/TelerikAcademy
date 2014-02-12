using System;
using System.Collections.Generic;

namespace SchoolHierarchy
{
    public class School
    {
        private string schoolName;
        private List<Student> students = new List<Student>();
        private List<Course> courses = new List<Course>();

        public School(string name)
        {
            this.SchoolName = name;
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
        }

        public List<Course> Courses
        {
            get
            {
                return this.courses;
            }
        }

        public string SchoolName
        {
            get
            {
                return this.schoolName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Course must have a name!");
                }

                this.schoolName = value;
            }
        }

        public void AddCourse(Course course)
        {
            if (this.courses.Contains(course))
            {
                throw new ArgumentException("The school already has this course");
            }

            this.courses.Add(course);
        }

        public void AddStudent(Student student)
        {
            if (this.students.Contains(student))
            {
                throw new ArgumentException("There student with that ID already.");
            }

            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (!this.students.Contains(student))
            {
                throw new ArgumentException("There is no such student in the school.");
            }

            this.students.Remove(student);
        }
    }
}
