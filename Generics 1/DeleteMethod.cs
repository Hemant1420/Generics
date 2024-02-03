using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class DeleteArray
    {
        public void DeleteMethod(int[] arr)          //Method to delete a Integer element from list
        {
            foreach(int ele in arr)                  //Printing The Array
            {
                Console.Write(ele + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Enter the element you want to delete: ");
            int element = Convert.ToInt32(Console.ReadLine());

            List<int> ints = new List<int>(arr);   //Converting the array into a list
            ints.Remove(element);                  //removing the element from list

            int[] newArray = ints.ToArray();

            foreach(int ele in newArray)           //Printing the new array
            {
                Console.Write(ele + " ");
            }

            Console.WriteLine() ;   

            

        }

        public void DeleteMethod(string[] arr)    //Method to delete a string element from list
        {

            foreach(string ele in arr)             //Printing the Array
            {
                Console.Write(ele + " ");
            }

            Console.WriteLine() ;
            
            Console.WriteLine("Enter the element you want to delete: ");
            string element = Console.ReadLine();

            List<string> str = new List<string>(arr);   //Converting the array into a list
            str.Remove(element);                  //removing the element from list

            string[] newArray = str.ToArray();

            foreach (string ele in newArray)
            {
                Console.Write(ele + " ");
            }

            Console.WriteLine();

            
        }

        public void DeleteMethod(char[] arr)
        {

            
            foreach (char ele in arr) //Printing the Array
            {
                Console.Write(ele + " ");
            }

            Console.WriteLine();
            
            Console.WriteLine("Enter the element you want to delete: ");    //Method to delete a character element from list
            char element = Convert.ToChar(Console.ReadLine());

            List<char> character = new List<char>(arr);   //Converting the array into a list
            character.Remove(element);                  //removing the element from list

            char[] newArray = character.ToArray();

            foreach (char ele in newArray)
            {
                Console.Write(ele + " ");
            }

            Console.WriteLine();
            
        }

    }


   
}
