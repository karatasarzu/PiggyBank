﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank.Exception_Library
{
    public class KumbaraKullanilamazException : Exception
    {
        public KumbaraKullanilamazException() : base("Kumbara bir daha kullanılamaz!")
        {

        }
    }
}
