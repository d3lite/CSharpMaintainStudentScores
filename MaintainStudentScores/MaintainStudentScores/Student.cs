using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintainStudentScores
{
    public class Student
    {
        private string name;
        private int score;
     

        public Student()
        {

        }

        public Student (string name, int score)
        {
            this.name = name;
            this.score = score;
        }
        public Student (int score)
        {
            this.score = score;
          
        }
      

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }

        }
 

        public string GetDisplayText() => 
        
            name + " " + score + " ";
        
        public string GetDisplayScore() => score + " ";

   
    }
}
