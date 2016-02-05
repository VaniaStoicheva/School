using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_part1
{
   class Students:People
    {
        private int uniqueStudentNumber;
        public string StudentName { get; set; }
        
       public Students(string studentName, int uniqueStudentNumber)
           :base(studentName)
        {
            
            this.uniqueStudentNumber = uniqueStudentNumber;
        }
        public int UniqueStudentNumber
        {
            get
            {
                return this.uniqueStudentNumber;
            }
            set
            {
                if(value<0)
                {
                    throw new ArgumentException("The number be positive");
                }
                this.uniqueStudentNumber=value;
            }
        }
        public override string ToString()
        {
            return String.Format("Student name:" + this.Name + " "+"student number:" + this.uniqueStudentNumber);
        }

        
            
        }
    }

