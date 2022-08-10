using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syap2
{
    [Serializable]
    public class Master: Student
    {
        public string diploma;
        public Master()
        {

        }
        public Master(string name, string surname, string faculty, string diploma): base(name, surname, faculty)
        {
            this.diploma = diploma;
        }
        public string Diploma
        {
            get { return diploma; }
            set { diploma = value; }
        }
    }
}
