﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntanceVariablePrac32
{
    internal class Student
    {
        internal string name;
        internal int grade;

        public override string ToString()
        {
            return grade + "학년 " + name;
        }
    }
}
