using IntroductionDesignPatterns;

//Persona person = new Persona("María José", 24, "Ecuador");
//var jorge = new SportyPerson("Jorge", 39, "Ecuador");
//Console.WriteLine(person.Show());
//Console.WriteLine(jorge.Show());

List<IVolador> voladorList = new List<IVolador>();
var pato1 = new Pato();
var pato2 = new Pato();
var pato3 = new Pato();

voladorList.Add(pato1);
voladorList.Add(pato2);
voladorList.Add(pato3);

AVolar(voladorList);

void AVolar(List<IVolador> aves)
{
    foreach (var ave in aves)
    {
        ave.Vuela();
    }
}