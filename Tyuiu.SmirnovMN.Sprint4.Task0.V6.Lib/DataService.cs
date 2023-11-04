using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SmirnovMN.Sprint4.Task0.V6.Lib
{
    public class DataService : ISprint4Task0V6
    {
        public int GetSumOddArrEl(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            return sum;

        }
    }
}

