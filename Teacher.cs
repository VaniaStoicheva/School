using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_part1
{
    class Teacher:People
    {
        //field
       private List<Discipline> listDiscipline ;
      
        
        //constructor
        public Teacher(string teacersName)
            : base(teacersName)
        {
            listDiscipline=new List<Discipline>();
        }

        
        public List<Discipline> ListDiscipline { get; set; }
       

        //Method
     public void AddDiscipline(string name,int lectures,int exercises)
        {
            Discipline discipline = new Discipline(name,lectures,exercises);
            
            this.listDiscipline.Add(discipline);
    }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            
            result.AppendFormat("Teachers name :"+this.Name);
            result.AppendLine();
           
            
            foreach (var discipline in listDiscipline)
            {
                result.AppendFormat(" ["+discipline.ToString()+" ]");
                result.AppendLine();
                
            }
         
            return result.ToString();
        }


       
    }
}
