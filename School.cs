using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_part1
{
    class School
    {
        public string SchoolName { get; set; }
        private List<Classes> classes;

        public School(string schoolName)
        {
            this.SchoolName = schoolName;
            this.classes = new List<Classes>();
        }
        public List<Classes> Classes
        {
            get
            {
                return this.classes;
            }
            
        }

        public void AddClass(string uniqueNumber)
        {
            Classes classe = new Classes(uniqueNumber);

            this.classes.Add(classe);
        }


        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach (var name in this.SchoolName)
            {
                result.Append(name.ToString());
            }
            result.AppendLine();
            foreach (var classe in this.classes)
            {
             result.Append(classe.ToString());
                
            }
            result.AppendLine();
                return result.ToString();
            }
        }
    }

