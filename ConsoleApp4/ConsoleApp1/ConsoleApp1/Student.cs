﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public abstract void Display();
    }
}
