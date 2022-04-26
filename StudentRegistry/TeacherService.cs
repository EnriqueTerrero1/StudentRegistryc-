using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistry
{
    public class TeacherService
    {
        StudentDBcontext db = new StudentDBcontext();
            
        public void GetTeachers()
        {
        foreach (Teacher t in db.Teachers)
                {
                    Console.WriteLine(t.Id +" "+ t.Name);
                }
         }
      // public void getAllStudent()
        //{
            
          //List <Student>studen = db.Teachers.Where(t => t.Id ==1).Include(t=>t.Students).ToList();

        //}
    }
}

