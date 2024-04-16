using Demo_OOP.Classes;
using Demo_OOP.Utils;

var poderVolar = new SuperPoder()
{
    Nombre = "Volar",
    Descripcion = "Capacidad para volar en el aire",
    Nivel = NivelPoder.Fuerte
};

var superFuerza = new SuperPoder()
{
    Nombre = "Super Fuerza",
    Descripcion = "Super Fuerza",
    Nivel = NivelPoder.SuperFuerte
};

var poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFuerza);

var wolverine = new AntiHeroe();
wolverine.Id = 2;
wolverine.Name = "Wolverine";

var superMan = new SuperHeroe()
{
    Id = 1,
    Name = "Superman",
    Ciudad = "Metropolis",
    IdentidadSecreta = "Clark Kent",
    PuedeVolar = true,
    SuperPoderes = poderesSuperman
};

var imprimirInfo = new ImprimirInfo();
imprimirInfo.ImprimirSuperHeroe(superMan);

Console.WriteLine(superMan.UsarSuperPoderes());