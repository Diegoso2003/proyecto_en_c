namespace Proyecto1.Mapa;
using Proyecto1.Imagen;
public class CasillaEnemigosFuertes : Casilla
{
    public CasillaEnemigosFuertes() : base(Imagenes.CasillaEnemigosFuertes.Imagen) { }
    internal override void AccionCasilla(Jugador.Jugador jugador)
    {
        throw new NotImplementedException();
    }
}
