﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class TooOldException : Exception
    {
        public TooOldException() 
            : base() {}
    }
}