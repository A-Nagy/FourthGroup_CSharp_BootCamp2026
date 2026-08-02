using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_4.Day_8.Employee_18
{
     class Employees
    {
        /*
         * **Employee**
         - Properties: `Name`, `Salary`
         - Functions:
          - `CalculateAnnualSalary()` → returns yearly salary
          - `GetAnnualSalaryLevel(double annualSalary)` → same but receives salary as a parameter
          - `GetAnnualSalaryLevel()` → returns salary level based on computed annual salary
    
         */
        //fields
        public string _name;
        public double _salary;

        //functions
        // ✅ الطريقة الثانية: تعتمد على الخصائص الداخلية للكائن
        public double CalculateAnnualSalary()
        {
            return _salary * 12;
        }
        public string GetAnnualSalaryLevel()
        {
            double annualSalary = CalculateAnnualSalary();

            if (annualSalary < 50000)
            {
                return "Low";
            }
            else if (annualSalary >= 50000 && annualSalary < 100000)
            {
                return "Medium";
            }
            else
            {
                return "High";
            }
        }


        // ✅ الطريقة الاولي: تعتمد على قيمة تمرر لها (parameter)
        public string GetAnnualSalaryLevel(double annualSalary)
        {
            if (annualSalary < 50000)
            {
                return "Low";
            }
            else if (annualSalary >= 50000 && annualSalary < 100000)
            {
                return "Medium";
            }
            else
            {
                return "High";
            }
        }

    }
}
