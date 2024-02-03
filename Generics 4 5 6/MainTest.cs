using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Generics_5
{
    internal class MainTest
    {
        static void Main()
        {
            int[] arr = { 1, 2, 5, 6, 8, 4 };
            float[] arr1 = { 12.4f, 5.4f, 5.54f, 7.75f, 89.8f };
            string[] arr2 = { "amey", "Hemant", "Rohan", "Rahul" };
            Minnumber minNumber = new Minnumber();
            minNumber.Minnum(arr);
            minNumber.Minnum(arr1);

            MinString<string> minNumber1 = new MinString<string>();
            minNumber1.Minnum(arr2);


        }
    }
}
