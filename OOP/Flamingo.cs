using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Flamingo : Bird
    {

        private bool isfly;

        public bool Isfly
        {
            get { return isfly; }
            set { isfly = value; }
        }
    }
}
