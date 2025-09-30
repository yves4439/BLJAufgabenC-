using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe12
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        static int[] SumUp(int[] arr)
        {
            int[] result = new int[arr.Length];

            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                result[i] = sum;
            }

            return result;
        }
    }
}
