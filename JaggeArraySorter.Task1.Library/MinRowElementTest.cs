﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray.Task2
{
    class MinRowElementTest : AbstractComparisonTest
    {
        protected override int Operation(int previous, int current)
        {
            if (current < previous)
            {
                return current;
            }
            return previous;
        }
    }
}
