namespace Proyecto1.Personajes;

public class Guerrero : Personaje
{
    public Trabajos.Trabajo TrabajoActual{get; set;}
    private readonly Trabajos.Trabajo[] TrabajosDisponibles;
    
    public Guerrero(Trabajos.Trabajo trabajo, string nombre) : base(nombre)
    {
        TrabajosDisponibles = new Trabajos.Trabajo[2];
        TrabajosDisponibles[0] = trabajo;
        TrabajoActual = trabajo;
    }

    public override void Atacar(Personaje personaje)
    {
    }

    public override void Defenderse(Personaje personaje)
    {
    }

    public void AgregarTrabajo(Trabajos.Trabajo trabajo)
    {
        if(TrabajosDisponibles[1] != null)
        {
            
        }
    }
}
