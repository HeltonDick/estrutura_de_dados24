using System.Collections;

// Utilizando a lista simples
Array arrList = new();
arrList.add(5);
arrList.add("Eto");
// É possivel adicionar um conjunto de valores de uma só vez
arrList.AddRange(new int[] [1,2,3]);
// O metodo add incere o valor ao final do vetor
arrList.incert(0, 15);
// Já o metodo incert me permite incluir o valor desejada na posição especificada no primeiro parâmetro

// Lendo valores da lista
object primeiro = arrList[0]!;
int quarto = (int) arrList[3]!;

// Percorrendo a lista com foraech
foreach (object obj in arrList) {
    Console.Write($" | {obj}");
}


// Obtendo o tamanho total da lista
// Quantos elementos tem
int tamanho = arrList.Count;
// Obter a capacidade
// Quantos podem ser armazenados
int capa = arrList.Capacity;

// Percorrendo do modo classico
for (int i = 0; i < arrList.Count; i ++) {
    Console.Write($" | {arrList[i]}");
}

// Recursos importantes da lista
// Verificar se um valor é contido na lista
bool contemNome = arrList.Contains("eto");
if (!contemNome){
    Console.WriteLine("Nome do mano ae não encontrado");
}

// Para saber o indice que contem o valor buscado
// Neste caso se o valor existir na lista ele retorna o indice (número inteiro
// Caso o valor não exista na lista retorna -1
int indiceValor = arrList.IndexOf("eto");
if(indiceValor >= 0) {
    Console.WriteLine($"eto está em {indiceValor}");
}
else {
    Console.writeLine("Valor não encontrado");
}

// É possivel também remover itens da lista
arrList.Remove("eto"); // Remove pelo valor
arrlist.RemoveAt(4); // Remove no indice
arrList.RemoveRange(0,1) // O primeiro parametro é o indice e o segundo é quantas casas após o indice