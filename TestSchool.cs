using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_part1
{
    class TestSchool
    {
        public static void Main()
        {
            School schoolVL= new School("Vasil Levski");
            schoolVL.AddClass("classA");
            schoolVL.AddClass("classB");

           Classes classB = new Classes("1B");
           
            Teacher teach = new Teacher("Popov");
            teach.AddDiscipline("fizika", 1, 1);
            teach.AddDiscipline("himia", 4, 4);
            classB.AddTeacher(teach);
          
           classB.AddStudent("Iva", 21);

           Classes classA = new Classes("1A");
           Teacher teach1 = new Teacher("Ivanov");
           teach1.AddDiscipline("It", 1, 1);
           teach1.AddDiscipline("Mat", 4, 4);
           classA.AddTeacher(teach1);
            classA.AddStudent("Ivan", 2);
            
            Console.WriteLine(schoolVL.ToString());
           Console.WriteLine( (classA.ToString()));
           Console.WriteLine((classB.ToString()));
            

            
            
            

          
        
        }
    }
}
