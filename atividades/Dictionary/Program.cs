// Diferente da TabelaHash, o Dictionary nos permite especificar o tipo de dado que cera utilizado nos pares key -> value
// Isso nos fornece uma estrutura fortemente tipada
using Dictionary;

Dictionary<string, string> dictionary = new Dictionary<string, string>() {
    { "Chave1", "Valor1" },
    { "Chave2", "Valor2" },
};

// O beter o valor do Dictionary

string val = dictionary["chave1"];

try {

}
catch (Exception ex) {
    val = dictionary["Chave3"];
    Console.WriteLine("Erro ao obter o valor de chave 3");
    Console.WriteLine(ex.Message);
}

// Verificando se a chave existe ante de acessar para evitar erros e prejuizos de execução
if (dictionary.ContainsKey("Chave2")) {
    Console.WriteLine($"Chave2: {dictionary["Chave2"]}");
}

// Outra forma de obter valor e evitar erro
var valor = dictionary.TryGetValue("Chave4", out string? value);
if (value is not null) {
    Console.WriteLine($"Chave4: {valor}");
}

// Podemos adicionar de mesma forma pela chave existente
dictionary["Chave0"] = "Valor0";

// Percorrer o dicionario
foreach (KeyValuePair<string, string> kvp in dictionary) {
    Console.WriteLine($"{kvp.Key}:{kvp.Value}");
}

// Utilizando tipos abstratos de dados com dicionario

Dictionary<int, Pessoa> dickPessoa = new Dictionary<int, Pessoa>();

dickPessoa.Add(1, new Pessoa() {
    Id = 0,
    BirthDate = new DateTime(2005, 5, 26),
    Name = "Helton Gabriel Dick"
    }
);

foreach (KeyValuePair<int, Pessoa> kvp in dickPessoa) {
    Console.WriteLine(kvp.Key);
    Console.WriteLine(kvp.Value.Id);
    Console.WriteLine(kvp.Value.Name);
    Console.WriteLine(kvp.Value.BirthDate);
}