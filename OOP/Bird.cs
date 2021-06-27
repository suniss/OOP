using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Bird : Animal
    {

        private int wingspan;

        public int Wingspan
        {
            get { return wingspan; }
            set { wingspan = value; }
        }
    }
}
