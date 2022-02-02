using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 7, 5, 1, 8, 3, 6, 0, 9, 4, 2 };
            object sortedArray = BinarySearchDisplay(array,6); 
        }

        public static object BinarySearchDisplay(int[] arr, int key)
        {
            int minNum = 0;
            int maxNum = arr.Length - 1;

            while (minNum <= maxNum)
            {
                int mid = (minNum + maxNum) / 2;
                if (key == arr[mid])
                {
                    return ++mid;
                }
                else if (key < arr[mid])
                {
                    maxNum = mid - 1;
                }
                else
                {
                    minNum = mid + 1;
                }
            }
            return "None";
        }
    }
}
