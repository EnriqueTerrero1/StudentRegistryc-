using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistry
{
    public class Menu
    {
       public void menu()
        {
            int option;
            do
            {
                StudentService studentService = new StudentService();
                Console.WriteLine("Bienvenido Registro al Registro de estudiantes");
                Console.WriteLine("1-Obtener lista de estudiante");
                Console.WriteLine("2-Agregar estudiante");
                Console.WriteLine("3-Editar lista de estudiante");
                Console.WriteLine("4-Eliminar lista de estudiante");
                Console.WriteLine("5-Filtro de estudiantes por profesor");
                Console.WriteLine("6-Salir");

                Console.WriteLine("Eliga una opcion");


                 option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        studentService.GetAll();
                        break;
                    case 2:
                        studentService.Create();
                        break;
                    case 3:
                        studentService.Update();
                        break;
                    case 4:
                        studentService.Delete();
                        break;
                    case 5:
                        studentService.filterStudentByTeacher();
                        break;


                }

            } while (option != 6);
        }
    }
}
