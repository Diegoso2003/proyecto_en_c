namespace Proyecto1.Mapa;
using Proyecto1.Imagen;
public class CasillaEnemigosDebiles : Casilla
{
    public CasillaEnemigosDebiles() : base(Imagenes.CasillaEnemigosDebiles.Imagen){}
    internal override void AccionCasilla(Jugador.Jugador jugador)
    {
        throw new NotImplementedException();
    }
}
