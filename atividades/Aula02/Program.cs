using Aula02;

Person person = new Person();
Console.WriteLine(person.Name);
//Console.WriteLine(person.Age);

Person person1 = new Person("Helton Dick", 19);
Console.WriteLine(person1.Name);
Console.WriteLine(person1.Age);

Person person2 = new Person();
person2.Name = "Pula vara";
person2.Age = 120;
Console.WriteLine(person2.Name);
Console.WriteLine(person2.Age);

Person person3 = new Person() {
    Name = "Leonel Messi",
    Age = 20
};
Console.WriteLine(person3.Name);
Console.WriteLine(person3.Age);