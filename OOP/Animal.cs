using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private double weight;



        public string Name
        {
            get { return name; }
            set { value = name; }
        }
        public int Age
        {
            get { return age; }
            set { value = age; }
        }
        public double Weight
        {
            get { return weight; }
            set { value = weight; }
        }

        public Animal()
        {
        }
        public Animal(string nam, int ag, double weg)
        {
            Name = nam;
            Age = ag;
            Weight = weg;
        }
        public abstract void DoSound();

        
    }


}

