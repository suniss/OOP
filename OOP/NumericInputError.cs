﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class NumericInputError : UserError

    {
        public override string UEMessage()
        {
            return "Your tried to use a numeric input in a text only field. This fired an error!";
        }
    }
}
