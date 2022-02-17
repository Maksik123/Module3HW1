using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Module3HW1.Services;

namespace Module3HW1.Services
{
    public class AddService
    {
        IncreaseSizeService increaseSize = new IncreaseSizeService();
        public int[] Add(int[] array, int number)
        {
            int[] arrayA = array;

            if (arrayA.Length - 1 != 0)
            {
                arrayA = increaseSize.Increase(arrayA);
                arrayA[arrayA.Length / 2] = number;
                return arrayA;
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
