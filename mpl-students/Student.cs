using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace syap2
{
    [Serializable]
    [XmlInclude(typeof(Master))]
    public class Student
    {
        public string name, surname, faculty;
        public Student()
        {

        }
        public Student(string name, string surname, string faculty)
        {
            this.name = name;
            this.surname = surname;
            this.faculty = faculty;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }

    }
}
