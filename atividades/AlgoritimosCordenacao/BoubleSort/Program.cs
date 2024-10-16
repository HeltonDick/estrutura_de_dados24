using System.Runtime.InteropServices;
using BubbleSort;

int[] inteiros = {0, 12, 7, 1, 8};
BubbleSort.BubbleSort.Print(inteiros);
BubbleSort.BubbleSort.Sort<int>(inteiros);
BubbleSort.BubbleSort.Print(inteiros);

Console.WriteLine("Teste char");
char[] chars= { 'x', 'z', 'b', 'c', 'a'};
BubbleSort.BubbleSort.Print(chars);
BubbleSort.BubbleSort.Sort(chars);
BubbleSort.BubbleSort.Print(chars);