using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsertionSort{
    public class InsertionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable {
            for (int i; i < array.Length; i++) {
                int j = i;
                While (j > 0 && array[j].CompareTo(array[j - 1]) > 0) {
                    Swap(array, j, j - 1);
                    j--;
                }
            }
        }

        public static void Swap<T>(T[] array, int first, int second) {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }

        public static void Print<T>(T[] array) {
            Console.Write('[');
            foreach (T i in array) {
            Console.Write($"{i} ");
            }
            Console.Write(']');
        }
    }
}