using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_5
{
    public class Minnumber
    {
        public void Minnum(int[] arr)
        {
            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }

            }
        }

        public void Minnum(float[] arr)
        {
            float min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }

            }

        }




    }

    public class MinString<T> where T : IComparable<T>
    {
        public void Minnum(T[] arr)
        {
            T min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].CompareTo(min) < 0)
                {
                    min = arr[i];
                }

            }

        }
    }
}
