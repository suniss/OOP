using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Dog : Animal
    {
        private bool bark;

        public bool Bark
        {
            get { return bark; }
            set { bark = value; }
        }
    }
}