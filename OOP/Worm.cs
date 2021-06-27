using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Worm : Animal
    {
        private bool isPoinsion;

        public bool IsPoinsion
        {
            get { return isPoinsion; }
            set { isPoinsion = value; }
        }



    }
}
