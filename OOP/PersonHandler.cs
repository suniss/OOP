using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class PersonHandler
    {
        public void SetAge(Person pers, int age)

        {
            pers.Age = age;
        }

        public int GetAge(Person pers, int age)
        {
            return pers.Age;


        }
        public void SetName(Person pers, string fname)
        {
            pers.FName = fname;
        }
        public string GetName(Person pers, string fname)
        {
            return pers.FName + " " + pers.FName;
        }
        public void SetLName(Person pers, string lname)
        {
            pers.LName = lname;
        }
        public string GetLName(Person pers, string lname)
        {
            return pers.LName + " " + pers.LName;
        }

        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }
        public string GetHeight(Person pers, string height)
        {
            return height;
        }
        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }
        public string GetWeight(Person pers, string weight)
        {
            return weight;
        }
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)

        {
            Person pers = new Person();
            SetAge(pers, age);
            SetName(pers, fname);
            SetLName(pers, lname);
            SetHeight(pers, height);
            SetWeight(pers, weight);

            return pers;

        }

    }
    
}
