using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistry
{
    public class Teacher:Person
    {
        public int Id { get; set; }
        public string grade { get; set; }
        public string classRoom { get; set; }
       
        public ICollection<Student>? Students { get; set; }  
    }
}
