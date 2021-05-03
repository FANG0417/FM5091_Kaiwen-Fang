﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace WindowsFormsApp3
{
    public class European: Option
    {
        public override double payoff1(Value value1, double[,] tree1, int i)
        {
            if (value1.Type == true)
                return Math.Max(tree1[i, value1.N] - value1.K, 0);
            else
                return Math.Max(-tree1[i, value1.N] + value1.K, 0);
        }

        public override double payoff2(Value value1, double[,] tree2, int i)
        {
            if (value1.Type == true)
                return Math.Max(tree2[i, value1.N] - value1.K, 0);
            else
                return Math.Max(-tree2[i, value1.N] + value1.K, 0);
        }

    }

}
