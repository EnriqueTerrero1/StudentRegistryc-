using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistry
{
    public class Person
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public int Age { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-mm-dd}",ApplyFormatInEditMode =true)]
        public DateTime birthDay { get; set; }
        public string address { get; set; }
       
    }
}
