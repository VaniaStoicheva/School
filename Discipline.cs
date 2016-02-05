using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_part1
{
    class Discipline
    {
        //property
        public string DisciplineName { get; set; }
        public int Lectures {get;set; }
        public int Exercises { get; set; }
        
        //constuctor
        public Discipline(string disciplineName, int lectures, int exercises)
           
        {
            this.DisciplineName = disciplineName;
            this.Lectures = lectures;
            this.Exercises = exercises;
        }

        public override string ToString()
        {
            return String.Format("discipline :" + this.DisciplineName+ " "+ "lectures number :" + this.Lectures
                +" "+"exercises number :" + this.Exercises);
           
        }
    }
}
