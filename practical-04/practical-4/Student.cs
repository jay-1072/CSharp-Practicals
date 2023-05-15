using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_4
{
    enum Options
    {
        Average = 1,
        MinMark = 2,
        MaximumMark = 3,
        Grade = 4
    }
    class Student
    {
        public string? Name;
        public decimal[]? Marks = new decimal[5];
        public static decimal AverageMarks;
                
        public decimal CalculateAverageMarks(decimal[] Marks)
        {
            AverageMarks = Marks.Sum()/Marks.Length;
            return AverageMarks;
        }        

        public string CalculateGrade(decimal marks)
        {
            string grade = string.Empty;

            if (marks > 90)
                grade = "A";
            else if(marks > 80)
                grade = "B";
            else if(marks > 70)
                grade = "C";
            else
                grade = "D";

            return grade;
        }
    }
}
