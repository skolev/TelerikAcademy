using System;

namespace SchoolHierarchy
{
    // more info about IEquatable<T>: http://msdn.microsoft.com/en-us/library/bhkz42b3.aspx
    public class Student : IEquatable<Student>
    {
        private string name;
        private int uniqueId;

        public Student(string name, int id)
        {
            this.Name = name;
            this.UniqueId = id;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Every student has a name.");
                }

                this.name = value;
            }
        }

        public int UniqueId
        {
            get
            {
                return this.uniqueId;
            }

            set
            {
                if (10000 > value && value < 99999)
                {
                    throw new ArgumentOutOfRangeException("Student ID number must be in the interval [10000, 99999]");
                }

                this.uniqueId = value;
            }
        }

        public bool Equals(Student other)
        {
            if (this.UniqueId == other.UniqueId)
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
