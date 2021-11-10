using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Search
{
    class Sax : IStrategy
    {
        public Sax(string path)
        {
            BestReader = new XmlTextReader(path);
        }

        private List<Student> info = new List<Student>();
        private XmlTextReader BestReader;
        
        public List<Student> Algorithm(Student student, string path)
        {
            info.Clear();

            List<Student> result = new List<Student>();
            Student st = null;
            string _speciality = null;
            string _group = null;
            

            while (BestReader.Read())
            {
                if (BestReader.Name == "dorm")
                {
                    while (BestReader.MoveToNextAttribute())
                    {
                        if (BestReader.Name == "DORM")
                        {
                            _speciality = BestReader.Value;
                        }
                    }
                }

                if (BestReader.Name == "floor")
                {
                    while (BestReader.MoveToNextAttribute())
                    {
                        if (BestReader.Name == "FLOOR")
                        {
                            _group = BestReader.Value;
                        }
                    }
                }

                if (BestReader.Name == "student")
                {
                    if (st == null)
                    {
                        st = new Student();
                        st.Dorm = _speciality;
                        st.Floor = _group;
                    }
                    else
                    {
                        st = new Student();
                        st.Dorm = _speciality;
                        st.Floor = _group;
                    }

                    if (BestReader.HasAttributes)
                    {
                        while (BestReader.MoveToNextAttribute())
                        {
                            if (BestReader.Name == "ROOM")
                            {
                                st.Room = BestReader.Value;
                            }
                            if (BestReader.Name == "SURNAME")
                            {
                                st.Surname = BestReader.Value;
                            }
                            if (BestReader.Name == "NAME")
                            {
                                st.Name = BestReader.Value;
                            }
                            if (BestReader.Name == "PHONENUMBER")
                            {
                                st.PhoneNumber = BestReader.Value;
                            }
                        }
                    }
                    if (st.Surname != null)
                    {
                        result.Add(st);
                    }
                }
            }
            info = Filtr(result, student);
            return info;
        }
        
        public List<Student> Filtr(List<Student> allStud, Student param)
        {
            List<Student> result = new List<Student>();
            if (allStud != null)
            {
                foreach(Student e in allStud)
                {
                    try
                    {
                        if ((e.Dorm == param.Dorm || param.Dorm == null) &&
                            (e.Floor == param.Floor || param.Floor == null) &&
                            (e.Room == param.Room || param.Room == null) &&
                            (e.Surname == param.Surname || param.Surname == null) &&
                            (e.Name == param.Name || param.Name == null) &&
                            (e.PhoneNumber == param.PhoneNumber || param.PhoneNumber == null)
                            )
                        {
                            result.Add(e);
                        }
                    }
                    catch { }
                }
            }
            return result;
        }
    }
}
