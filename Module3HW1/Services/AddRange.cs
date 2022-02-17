using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW1.Services
{
    public class AddRange
    {
        IncreaseSizeService increaseSize = new IncreaseSizeService();
        public int[] Addrange(int[] array, int[] userNumbers)
        {
            int[] arrayA = array;
            var counterLength = 0;

            for (int counter = 0; counter < userNumbers.Length; counter++)
            {
                int number = userNumbers[counter];
                if (arrayA.Length - 1 != 0)
                {
                    arrayA = increaseSize.Increase(arrayA);
                    arrayA[arrayA.Length / 2 + counterLength] = number;
                    counterLength++;
                }
                else
                {
                    arrayA[arrayA.Length + counterLength] = number;
                }
            }
            return arrayA;
        }
    }
}
