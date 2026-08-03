using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_4.Day_8.Patient_20
{
     class Patients
    {
        /*
         * . **Patient**
              - Properties: `Name`, `Height`, `Weight`
             - Functions:
              - `GetBMI()` → calculates Body Mass Index
              - `GetBodyStatus()` → returns weight classification
         */

        private string name;
        private double height;
        private double weight;

        public string Name { get => name; set => name = value; }
        public double Height { get => height; set => height = value; }
        public double Weight { get => weight; set => weight = value; }

        public Patients(string name , double height, double weight)
        {
            Name = name;
            Height = height;
            Weight = weight;
            
        }
       public double GEtBMI() 
        {
            return Weight / (  Height * Height );
        }
        public string GetBodyStatus() 
        {
            double Bmi = GEtBMI();
            return Bmi <= 18.5 ? "Under Weight"  :
                   Bmi <= 25   ? "Normal Weight" :
                   Bmi <= 30   ? "OverWieght"    : "Obasty";
 
        }


    }
}
