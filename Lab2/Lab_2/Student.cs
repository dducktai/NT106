using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    [Serializable]
    public class Student
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public float Math { get; set; }
        public float Literature { get; set; }
        public float Average { get; set; }
        public override string ToString()
        {
            return ID + "\n" + Name + "\n" + Phone + "\n" + Math + "\n" + Literature + "\n" + Average;
        }
    }
}
