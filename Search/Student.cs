using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    class Student
    {
        public string Dorm = null;
        public string Floor = null;
        public string Room = null;
        public string Surname = null;
        public string Name = null;
        public string PhoneNumber = null;

        public Student() { }

        public Student(string[] data)
        {
            Dorm = data[0];
            Floor = data[1];
            Room = data[2];
            Surname = data[3];
            Name = data[4];
            PhoneNumber = data[5];
        }
        public Student(IStrategy algo)
        {
            Dorm = String.Empty;
            Floor = String.Empty;
            Room = String.Empty;
            Surname = String.Empty;
            Name = String.Empty;
            PhoneNumber = String.Empty;
        }

        public bool Comparing(Student student)
        {
            if ((this.Dorm == student.Dorm) &&
                (this.Floor == student.Floor) &&
                (this.Room == student.Room) &&
                (this.Surname == student.Surname) &&
                (this.Name == student.Name) &&
                (this.PhoneNumber == student.PhoneNumber))
                return true;
            else
                return false;
        }

        public IStrategy Algo { get; set; }

        public List<Student> Algorithm(Student parametrs, string path)
        {
            return Algo.Algorithm(parametrs, path);
        }

    }
}
