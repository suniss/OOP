using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        public int Age
        {
            get { return age; }
            set {
                
                    if (value > 0)
                    {
                        throw new ArgumentException("Age must be than 0");
                    }
                    else
                    {
                        age = value;
                    }
                }
            }
        public string FName
        {
            get { return fName; }   // get method
            set
            {
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException(" Name must have more than 2 characters or not more than 10 characters");
                }
                else
                {
                    lName = value;
                }  
            }  
        }
        public string LName
        {
            get { return lName; }   // get method
            set
            {
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Last Name must have more than 3 characters or more than 15 characters");
                }
                else
                {
                    lName = value;
                }
            }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

    }
}
