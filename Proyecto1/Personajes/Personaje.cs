namespace Proyecto1.Personajes;

public abstract class Personaje
{
    public int Nivel{get; private set;} = 1;
    public int Fuerza{get; private set;} = 1;
    public int Defensa{get; private set;} = 1;
    public int Concentracion{get; private set;}
    public int Espiritu{get; private set;}
    public int Velocidad{get; private set;}
    public int Vida{get; private set;}
    public int Experiencia{get; set;}
    public string Nombre{get; private set;}

    public Personaje(string nombre)
    {
        Nombre = nombre;
    }

    public bool EstaVivo()
    {
        return Vida > 0;
    }

    public abstract void Atacar(Personaje personaje);
    public abstract void Defenderse(Personaje personaje);
}
