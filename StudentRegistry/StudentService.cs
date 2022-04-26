using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistry
{
    internal class StudentService:IMethods
    {
        StudentDBcontext db = new StudentDBcontext();
       
        
        public void Create()
        {
            
                db.Add(fillStudent());
                db.SaveChanges();
        }
        public void Delete()
        {
            Console.WriteLine("Indique el id del estudiante a eliminar");
              
                int id = int.Parse(Console.ReadLine());
                db.Remove(db.Students.Find(id));
                db.SaveChanges();

        }
        public void GetAll()
        {
            
              foreach(Student s in db.Students)
                {

                    Console.WriteLine($"Nombre : {s.Name} ID :{s.Id} Aula :{s.classRoom}");
                }
            
        }

        public void Update()
        {
            Console.WriteLine("Escriba el id del estudiante a actualizar");
            int id =int.Parse(Console.ReadLine());

            var newStudent = fillStudent();
           
            var student = db.Students.Where(s => s.Id == id).FirstOrDefault();
            newStudent.Id = student.Id;
            //db.Students.Remove(student);
         db.Entry(student).CurrentValues.SetValues(newStudent);
            db.Students.Update(student);
            db.SaveChanges();

        }
      

        public Student fillStudent()
        {
            Student student = new Student();
            Console.WriteLine("Escriba el nombre del estudiante");
            student.Name = Console.ReadLine();
            Console.WriteLine("Escriba la edad del estudiante");
            student.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba la direccion del estudiante");
            student.address = Console.ReadLine();
            Console.WriteLine("Eliga el id de su profesor");
            TeacherService teacherService = new TeacherService();
            teacherService.GetTeachers();
            int teacherid = int.Parse(Console.ReadLine());
            var teacher = new Teacher();
            teacher = db.Teachers.Find(teacherid);
            student.Teacher = teacher;
            student.birthDay = DateTime.Now;
            student.grade = "10";
            Console.WriteLine("Escriba el aula del estudiante");
            student.classRoom = Console.ReadLine();
            return student;

        }

        public  void filterStudentByTeacher()
        {
            Console.WriteLine("filtrado por profesor");
            Console.WriteLine("Indique el ID del profeesor");
            int id =int.Parse(Console.ReadLine());
          

            var studentFromTeacher = from s in db.Students
                                  where s.Teacher.Id== id 
                                  select s;
            Console.WriteLine("Estudiantes por profesor");

            foreach (Student std in studentFromTeacher)
            {
                Console.WriteLine(std.Name);
            }
        }





    }

    }

