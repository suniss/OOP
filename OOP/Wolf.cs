using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Wolf : Animal
    {

        private int danger;

        public Wolf(int danger)
        {
            this.danger = danger;
        }

        public int Danger
        {
            get { return danger; }
            set { danger = value; }
        }

    }
}
