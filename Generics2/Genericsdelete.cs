using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Generics 
{
    public class DeleteArray <T>
    {
        public void DeleteMethod(T[] arr)        //Method to delete a Integer element from list
        {
            foreach (T ele in arr)                  //Printing The Array
            {
                Console.Write(ele + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Enter the index of element you want to delete: ");
            int element = Convert.ToInt32(Console.ReadLine());


            List<T> ints = new List<T>(arr);        //Converting the array into a list
            ints.RemoveAt(element);                   //removing the element from list
                                                      //converting back to Array
            T[] newArray = ints.ToArray();

            foreach (T ele in newArray)             //Printing the new array
            {
                Console.Write(ele + " ");
            }

            Console.WriteLine();



        }



    }



}