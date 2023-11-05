using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.BogdanovaSA.Sprint4.Task2.V30.Lib
{
    public class DataService
    {
        public int Calculate(int[] array)
        {
            int sumArray = 1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    sumArray *= array[i];
                }
            }

            return sumArray;
        }
    }
}
