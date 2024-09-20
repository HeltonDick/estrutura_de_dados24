int[] pairs = new int[50];
int[] odds = new int[50];
int pairIndex = 0;
int oddIndex = 0;

for (int i = 0; i < 100; i++) {
    if (i %2 == 0) {
        pairs[pairIndex] = i;
        pairIndex++;
    }
    else {
        odds[oddIndex] = i;
        oddIndex++;
    }

}

Console.WriteLine("---------------------");

for (int i = 0; i < 50; i++) {
    Console.WriteLine(pairs[i] + "\n" + odds[i]);
}

Console.WriteLine("---------------------");