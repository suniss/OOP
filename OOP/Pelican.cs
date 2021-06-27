using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Pelican : Bird
    {
        private bool likeFish;
        public bool LikeFish
        {
            get { return likeFish; }
            set { likeFish = value; }
        }
    }
}

