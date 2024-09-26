// Exemplo de uma agenda telefonica

using System.Collections;

Hashtable phoneBook = new Hashtable() {
    //{ "chave", "valor" },
    { "Helton", "99334515" },
    { "J", "58" },
    {"c", "35664953" },
};

// É possivel adicionar elementos de diverças formas
// Pelo proprio indice chave inexistente
phoneBook["M"] = "5566";

// Ou pelo metodo Add()
phoneBook.Add("N", "6169");

// Entretanto a tabela hash verifica se há duplicidade de chave e pode lançar uma exeption
try {
    phoneBook.Add("Helton", "99334515");
}
catch (Exception ex) {
    Console.WriteLine($"Erro ao tentar incerir o valor repetido");
    Console.WriteLine(ex.Message);
}

// Percorrendo itens da hash table
Console.WriteLine("Agenda telefonica:");
if (phoneBook.Count == 0) {
    Console.WriteLine("A agenda está vazia");
}
else {
    foreach (DictionaryEntry entry in phoneBook) {
        Console.WriteLine($"{entry.Key}:{entry.Value}");
    }
}