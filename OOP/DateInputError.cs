using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class DateInputError : UserError
    {
        public override string UEMessage()
        {
            return "Your tried to use a date input in a text only field. This fired an error!";
        }

    }
}
