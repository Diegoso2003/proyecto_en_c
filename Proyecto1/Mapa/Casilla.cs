namespace Proyecto1.Mapa;

public abstract class Casilla
{
    public string Imagen
    {get; private set;}

    public Casilla(string imagen)
    {
        Imagen = imagen;
    }

    internal abstract void AccionCasilla(Jugador.Jugador jugador);
}
