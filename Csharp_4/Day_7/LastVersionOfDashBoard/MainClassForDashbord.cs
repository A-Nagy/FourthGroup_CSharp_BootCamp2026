using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_4.Day_7.LastVersionOfDashBoard
{
     class MainClassForDashbord
    {
        
      
        static void Main(string[] args)
        {
              EmployeeClass emp = new EmployeeClass();
            int ch = 0;
            do
            {
            Console.WriteLine();
            Console.WriteLine("Chosse the Number Of System You Need To Use 1-4");
            Console.WriteLine(" 1.Employee Salary Information \n" +
                              " 2.Student Percentage Calculator \n" +
                              " 3.Patient BMI Calculator \n" +
                              " 4.Exit ");
            ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                        emp.Emp_Label();
                        //emp.InputData();

                        Console.Write("Enter your name: ");
                        string Name = Console.ReadLine();
                        Console.Write("Enter your monthly salary: ");
                        double Salary = Convert.ToDouble(Console.ReadLine());

                        string[] Sammary = emp.GetEmployeeSummary(Name, Salary);
                        foreach (string s in Sammary)
                        {
                            Console.WriteLine(s);
                        }

                        break;
                      

                 }
            } while (ch !=5 );
        }

      

    }
}
