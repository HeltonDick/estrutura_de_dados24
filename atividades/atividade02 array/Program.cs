int[] pairs;
int[] odds;
int[] complete;

for (int i = 0; i < 100; i++) {
    if (i %2 == 0) {
        pairs[i] = i;
    }
    else {
        odds[i] = i;
    }

    complete = pairs.Concat(odds).ToArray();

    foreach (int number in complete) {
    Console.WriteLine(number + " ");
}
}

Console.WriteLine("---------------------");


/*
// Array de números ímpares
int[] numerosImpares = Enumerable.Range(1, 100).Where(x => x % 2 != 0).ToArray();

// Array de números pares
int[] numerosPares = Enumerable.Range(1, 100).Where(x => x % 2 == 0).ToArray();

// Concatenando as duas arrays em uma só
int[] numerosCombinados = numerosImpares.Concat(numerosPares).ToArray();

// Exibindo o resultado
Console.WriteLine("Array combinada até 100:");
foreach (int numero in numerosCombinados){
    Console.Write(numero + " ");
}
*/