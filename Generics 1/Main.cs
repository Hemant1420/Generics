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

            int[] integer = { 1, 2, 3 ,4 ,5 ,6};
            string[] str = { "Rohan" ,"Amey" ,"Sahil" ,"Aman" ,"Hemant"};
            char[] character = { 'a', 'b', 'c' ,'d' ,'e' ,'f'};

            deleteInt.DeleteMethod(integer);
            deleteInt.DeleteMethod(str);
            deleteInt.DeleteMethod(character);
        }
    }
}
