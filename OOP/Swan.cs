using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Swan : Bird
    {

        private bool angry;

        public bool Angry
        {
            get { return angry; }
            set { angry = value; }
        }
    }
}
