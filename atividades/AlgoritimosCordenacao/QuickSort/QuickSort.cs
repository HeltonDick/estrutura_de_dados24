using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickSort { 
    
    public class QuickSort{
        public static T[] Sort<T>(T[] array, int lower, int upper)where T : IComparable {
            if (lower < upper) {
                int p = Partition(array, lower, upper);
                Sort(array, lower, p);
                Sort(array, p + 1, upper);
            };
            return array;
        }
    

        public static int Partition<T>(T[] array, int lower, int upper)where T : IComparable {
            int i = lower;
            int j = upper;
            T pivo = array[lower];

            do {
                while (array[i].CompareTo(pivo) < 0) {i ++;}
                while (array[j].CompareTo(pivo) > 0) {j --;}
                if (i >= j) {break;}
                Swap(array, i, j);
                //Swap
            }
            while(i <= j);
            return j;
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