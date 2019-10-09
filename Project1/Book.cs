using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class Book
    {
        public Book(string name)
        {
           grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        private List<double> grades = new List<double>();
        private string name;
        
    }
}