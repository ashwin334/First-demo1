using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
     public class Date  //--> members of class data member,method,properties,constructor,event
     {
        //variables,data members
        private int day, year;
        private string month;
        //create a method to assign value to data member

        public void Add(int day, string month, int year)
        {
            this.day = day; //this refers to data member
            this.month = month;
            this.year = year;
        }
        // method to retrieve data

        public string Print()
        {
            return $"Date: {day}/{month}/{year}";
        }
     }

}
    

