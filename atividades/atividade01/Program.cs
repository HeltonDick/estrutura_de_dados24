//Comentarios em c#

/*
    Comentario
    de
    multiplas
    linhas
*/

//Declarando variavel
int number;
//Atribuindo valor
number = 10;

//Declarando const
const int DAYS_IN_WEEK = 7;

//Imprimindo string concatenada
Console.WriteLine($"A semana tme {DAYS_IN_WEEK} dias.");

//new TipoEnumerador() -> invoca o metodo construtor do objeto
//Toda classe tem o seu construtor padrão implicito sem argumentos
//É possivel sobreescrever este metodo especificando argumentos
//Todavia, se o fizermos, perdemos o original implicito e 
//Precissaremos defini-lo explicitamente
TipoEnumerador tipoEnum = new TipoEnumerador();
TipoEnumerador.Language enumEnglish = tipoEnum.GetLenguageEnum("english");
Console.WriteLine($"O enum de english é {enumEnglish}");