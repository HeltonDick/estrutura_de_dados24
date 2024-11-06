using System.Runtime.InteropServices;
using MergeSort;

Console.WriteLine(" ");
Console.WriteLine("⫸Implementação do Merge Sort⫷");
int[] inteiros = {5, 100, 72, 33, 10, 90, 23, 1};

MergeSort.MergeSort.Print<int>(inteiros);
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("Iniciando ordenação");
Console.WriteLine(" ");

int[] organizados = MergeSort.MergeSort.Sort<int>(inteiros);
Console.WriteLine(" ");
Console.WriteLine("Ordenação completa");
MergeSort.MergeSort.Print<int>(organizados);