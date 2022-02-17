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

            for (int counter = 0; counter < userNumbers.Length; counter++)
            {
                int number = userNumbers[counter];
                if (arrayA.Length - 1 != 0)
                {
                    arrayA = increaseSize.Increase(arrayA);
                    arrayA[arrayA.Length / 2] = number;
                    return arrayA;
                }
            }


            else
            {
                for (int i = 0; i < arrayA.Length; i++)
                {
                    if (arrayA[i] == 0)
                    {
                        arrayA[i] = number;
                        return arrayA;
                    }
                }
            }
            return null;
        }
    }
}
