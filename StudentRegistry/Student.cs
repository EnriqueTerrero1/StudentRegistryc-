using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistry
{
    public class Student:Person
    {
        public int Id { get; set; }
       public string grade { get; set; }
       public Teacher Teacher { get; set; }
        public string classRoom { get; set; }
    }
}
