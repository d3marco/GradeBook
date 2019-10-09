using System;
using System.Collections.Generic;

namespace Project1
{
    class GradeBook
    {
        static void Main(string[] args)
        {
        
            var book = new Book("Scott's grade book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
           
            book.AddGrade(77.5);
            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);


            var result = 0.0;
            {
                foreach (var number in grades)
                {
                    result += number / grades.Count;
                }

                Console.WriteLine($"The average grade is {result}");
            }
            
        }
    }
}
