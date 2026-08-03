using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_4.Day_8.Student_19
{
     class Students
    {
        /*
         * **Student**
      - Properties: `Name`, `Mark`, `FullMark`
      - Functions: 
      - `GetPercentage()` → calculates result percentage
      - `GetGrade()` → returns grade based on percentage
         */
        private string name;
        private double mark;
        private double fullmark;

        public string Name 
        { 
            get => name;
            set => name = value;
        }
        public double Mark 
        {
            get => mark;
            set => mark = value; 
        }
        public double Fullmark 
        { 
            get => fullmark;
            set => fullmark = value;
        }

        public Students(string name , double mark , double fullmark )
        {
            Name = name;
            Mark = mark;
            Fullmark = fullmark;
            
        }


        public double GetPrecentage() 
        {
            return (Mark /Fullmark)*100;
        }
        public string GetGrade() 
        {double precentage = GetPrecentage();

            return precentage >= 90 ? "A" :
                   precentage >= 80 ? "B" :
                   precentage >= 70 ? "C" :
                   precentage >= 60 ? "D" : "F";
        }

    }
}
