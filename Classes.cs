using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace OOP_part1
{
    class Classes
    {
        public string UniqueClassIdentifiers { get; set; }
        private List<Students> students;
        private List<Teacher> teachers;

        public Classes(string uniqueClassIdentifiers)
        {
            this.UniqueClassIdentifiers = uniqueClassIdentifiers;
            this.students = new List<Students>();
            this.teachers = new List<Teacher>();
        }

        public List<Students> Students
        {
            get
            {
                return this.students;
            }
        }
        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }
        }
        public void AddTeacher(Teacher name)
        {
            //Teacher teacher = new Teacher(name);
            this.teachers.Add(name);
        }
        public void AddStudent(string name,int id)
        {
            Students stud = new Students(name,id);
            this.students.Add(stud);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var className in this.UniqueClassIdentifiers)
            {
                sb.Append(className.ToString());
            
            }
            sb.AppendLine();
            foreach (var teacher in this.teachers)
            {
                sb.Append(teacher.ToString());
            }
            foreach (var student in this.students)
            {
                sb.Append(student.ToString());
            }
            return sb.ToString();
        }
    

    }
}
