using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class EmailInPutError : UserError
    {
        public override string UEMessage()
        {
            return "Your tried to use a email input in a text only field. This fired an error!";
        }
    }
}
