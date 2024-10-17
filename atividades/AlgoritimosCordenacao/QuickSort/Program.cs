using System.Windows.Markup;

Console.WriteLine("TESTANDO O QUICK SORT");
int[] valores = new int[] {0, 15, 24, 1, 3, 6, 12, 9};
QuickSort.QuickSort.Print<int>(valores);
Console.WriteLine("Iniciando ordenação.");
QuickSort.QuickSort.Sort<int>(valores, 0, valores.Length - 1);
Console.WriteLine("Finzando orientação.");
QuickSort.QuickSort.Print<int>(valores);
