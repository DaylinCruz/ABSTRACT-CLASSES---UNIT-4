
Caballo caballo = new Caballo("Flika");
caballo.Respirar();

Humano humano = new Humano("David");

Gorila gorila = new Gorila("Hallu");
gorila.GetNombre();

Ballena ballena = new Ballena("Salet");

Lagartija lagartija = new Lagartija("Saora");
lagartija.GetNombre();

interface IMamiferosTerrestres
{
    int NumPatas();
}
interface IAnimalesYDeportes
{
    string TipoDeporte();
}

abstract class Animales
{
    public void Respirar()
    {
        Console.WriteLine("Soy capaz de respirar");
    }
    public abstract void GetNombre();
}

class Mamiferos:Animales
{
    private String nombreSerVivo;

    public Mamiferos(String nombre)
    {
        nombreSerVivo = nombre;
    }

    public virtual void pensar()
    {
        Console.WriteLine("Pensamiento básico instintivo");
    }

    public void cuidarCrías()
    {
        Console.WriteLine("Cuido a mis crías hasta que se valgan por sí solas");
    }

    public override void GetNombre()
    {
        Console.WriteLine("El nombre del mamífero es: " + nombreSerVivo);
    }
   
}

class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesYDeportes
{
    public Caballo(String nombre_caballo):base(nombre_caballo)
    {

    }
    public void Galopar()
    {
        Console.WriteLine("Soy capaz de galopar");
    }
    public int NumPatas()
    {
        return 4;
    }
    public string TipoDeporte()
    {
        return "carreras";
    }
}

class Humano : Mamiferos, IMamiferosTerrestres, IAnimalesYDeportes
{
    public Humano(String nombre_humano) : base(nombre_humano)
    {

    }
    public override void pensar()
    {
        Console.WriteLine("Soy capaz de pensar");
    }
    public int NumPatas()
    {
        return 2;
    }
    public string TipoDeporte()
    {
        return "Atletismo";
    }
}

class Gorila : Mamiferos, IMamiferosTerrestres
{
    public Gorila(String nombre_gorila) : base(nombre_gorila)
    {

    }
    //"override" para saber que no es un metodo diferente, sino una modificacion
    public override void pensar()
    {
        Console.WriteLine("Pensamiento instintivo avanzado");
    }
    public void Trepar()
    {
        Console.WriteLine("Soy capaz de trepar");
    }
    public int NumPatas()
    {
        return 2;
    }
}

class Ballena: Mamiferos
{
    public Ballena(String nombre_ballena):base(nombre_ballena)
    {

    }
    public void Nadar()
    {
        Console.WriteLine("Soy capaz de nadar");
    }
}

class Lagartija : Animales
{
    public Lagartija(String nombre)
    {
        Nombre_reptil = nombre;
    }
   
    public override void GetNombre()
    {
        Console.WriteLine("El nombre del reptíl es: " + Nombre_reptil);
    }
    private String Nombre_reptil;
}


