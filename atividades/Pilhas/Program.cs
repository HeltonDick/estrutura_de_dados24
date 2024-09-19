// As pilhas trabalham com uma estrutura LIFO -> Last In First Out
/* Três metodos importantes:
Push() - > Incere um elemento no topo da pilha
Pop() - > Remove um elemento do topo e o retorna
Peek() - > Retorna o elemento do topo sem remove-lo
*/

// Invertendo as bola
Stack<char> Caracteres = new Stack<char>();

foreach (char c in "DARCY DA MONTANHA") {
    Caracteres.Push(c);
}

// Desempilhando
string invertido = string.Empty;
while(Caracteres.Count > 0) {
    invertido += Caracteres.Pop();
}

Console.WriteLine(invertido);