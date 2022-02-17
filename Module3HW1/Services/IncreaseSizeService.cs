using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW1.Services
{
    internal class IncreaseSizeService
    {
        public int[] Increase(int[] array)
        {
            int counter = array.Length;
            int[] arrayA = new int[counter * 2];
            counter = 0;

            foreach (int i in array)
            {
                arrayA[counter] = i;
                counter++;
            }
            return arrayA;
        }
    }
}