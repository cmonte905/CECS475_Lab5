﻿using _475_Lab_4_Part_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer {
    class Program
    {
        static void Main(string[] args)
        {
         IBusinessLayer b = new BusinessLayer();
         b.GetStandardByID(1);
        }
    }
}


