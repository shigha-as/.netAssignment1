using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] employeeIds = { 10001, 10010, 10002, 10009, 10003, 10007, 10004, 10006, 10008, 10005 };
            int[] yearOfExperience = { 3, 5, 7, 2, 9, 10, 1, 10, 1, 11 };

            Array.Sort(yearOfExperience, employeeIds);

            for (int i = 0; i < employeeIds.Length; i++)
            {
                int employeeId = employeeIds[i];
                int years = yearOfExperience[i];
                int incentive = 0;

                if (years >= 0 && years <= 3)
                {
                    incentive = 10000;
                }
                else if (years >= 4 && years <= 6)
                {
                    incentive = 20000;
                }
                else
                {
                    incentive = 40000;
                }

                Console.WriteLine("Employee ID: " + employeeId + "Years of Experience: " + years + "Incentives: " + incentive);

            }
        }
    }
}
