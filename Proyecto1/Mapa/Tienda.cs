namespace Proyecto1.Mapa;
using Proyecto1.Imagen;

public class Tienda : Casilla
{

    public Tienda() : base(Imagenes.Tienda.Imagen) { }

    internal override void AccionCasilla(Jugador.Jugador jugador)
    {
    }
}
