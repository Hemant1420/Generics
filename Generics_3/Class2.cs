using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Main1
    {
        static void Main()
        {
            DeleteArray deleteInt = new DeleteArray();

            int[] integer = { 1, 2, 3, 4, 5, 6 };
            string[] str = { "Rohan", "Amey", "Sahil", "Aman", "Hemant" };
            char[] character = { 'a', 'b', 'c', 'd', 'e', 'f' };
            double[] doubles = {12.87, 34.5, 65.7, 2.76, 54.9, 12.2 };

            deleteInt.DeleteMethod(integer);
            deleteInt.DeleteMethod(str);
            deleteInt.DeleteMethod(character);
            deleteInt.DeleteMethod(doubles);
        }
    }
}