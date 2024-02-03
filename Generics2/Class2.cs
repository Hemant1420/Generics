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
            int[] integer = { 1, 2, 3, 4, 5, 6 };
            string[] str = { "Rohan", "Amey", "Sahil", "Aman", "Hemant" };
            char[] character = { 'a', 'b', 'c', 'd', 'e', 'f' };
            double[] doubles = { 12.87, 34.5, 65.7, 2.76, 54.9, 12.2 };

            DeleteArray<int> deleteInt = new DeleteArray<int>();
            deleteInt.DeleteMethod(integer);


            DeleteArray<string> deleteInt1 = new DeleteArray<string>();
            deleteInt1.DeleteMethod(str);


            DeleteArray<char> deleteInt2 = new DeleteArray<char>();
             deleteInt2.DeleteMethod(character);


            DeleteArray<double> deleteInt3 = new DeleteArray<double>();
            deleteInt3.DeleteMethod(doubles);
        }
    }
}