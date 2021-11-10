using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Search
{
    class Linq : IStrategy
    {
        private List<Student> info = new List<Student>();
        private XDocument doc = new XDocument();

        public Linq(string path)
        {
            doc = XDocument.Load(path);
        }

        public List<Student> Algorithm(Student student, string path)
        {
            List<XElement> match = (from val in doc.Descendants("student")
                                    where
                                    ((student.Dorm == null || student.Dorm == val.Parent.Parent.Attribute("DORM").Value) &&
                                    (student.Floor == null || student.Floor == val.Parent.Attribute("FLOOR").Value) &&
                                    (student.Room == null || student.Room == val.Attribute("ROOM").Value) &&
                                    (student.Surname == null || student.Surname == val.Attribute("SURNAME").Value) &&
                                    (student.Name == null || student.Name == val.Attribute("NAME").Value) &&
                                    (student.PhoneNumber == null || student.PhoneNumber == val.Attribute("PHONENUMBER").Value))
                                    select val).ToList();

            foreach (XElement obj in match)
            {
                Student student1 = new Student();
                student1.Dorm = obj.Parent.Parent.Attribute("DORM").Value;
                student1.Floor = obj.Parent.Attribute("FLOOR").Value;
                student1.Room = obj.Attribute("ROOM").Value;
                student1.Surname = obj.Attribute("SURNAME").Value;
                student1.Name = obj.Attribute("NAME").Value;
                student1.PhoneNumber = obj.Attribute("PHONENUMBER").Value;
                info.Add(student1);
            }
            return info;
        }
    }
}
