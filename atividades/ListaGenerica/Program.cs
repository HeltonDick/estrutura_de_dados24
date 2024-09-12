using ListaGenerica;

// <> = lista vai ser daquele determinado tipo de dado
List<double> numbers = new List<double> ();

do {
    Console.WriteLine("Diga um numero:");
    string? numberStr = Console.ReadLine ();
    // O ReadLine pode retornar string null, com o ponto de interrogação ela permite que a variavel pode ser null
    if (!double.TryParse (numberStr, out double number)) {
        break;
    }

    numbers.Add (number);
    Console.WriteLine ($"A media dos valores é {numbers.Average()}");
}
while (true);

// -- Lista de pessoas
List<Person> people = new List<Person> ();
Person p1 = new Person();
p1.Name = "Joaquin";
p1.Age = 16;
p1.Country = CountryEnum.PY;
people.Add (p1);

p1.Name = "Joaquin Dick";

people.Add(new Person() {
    Name = "Sharon Stone",
    Age = 60,
    Country = CountryEnum.PY,
});

Person p3 = new Person(){
    Name = "Arnold E-suasnega",
    Age = 63,
    Country = CountryEnum.JP
};

people.Add (p3);

//Formas de percorrear a lista generica

foreach (Person p in people) {
    Console.WriteLine(p.Name);
}

// Modo for tradicional

for (int i = 0; i < people.Count; i++) {
    Console.WriteLine($"Nome {people[i].Name}");s
}