namespace Proyecto1.Jugador;

using Imagen;
public class Jugador
{
    public string Nombre
    {get; set;} = "";
    public int Oro
    {get; set;} = 1000;
    public int PosicionX 
    {get; private set;} = 0;
    public int PosicionY
    {get; private set;} = 0;
    private readonly string imagen = Imagenes.Jugador.Imagen;

    public string Imagen
    {get{ return imagen; }}

    public void MoverseMapa(Mapa.Mapa mapa, string opcion)
    {
        int nuevaPosicionX = PosicionX;
        int nuevaPosicionY = PosicionY;
        opcion = opcion.ToLower();
        bool moverse = true;
        switch(opcion)
        {
            case "a":
                nuevaPosicionX--;
            break;
            case "s":
                nuevaPosicionY++;
            break;
            case "d":
                nuevaPosicionX++;
            break;
            case "w":
                nuevaPosicionY--;
            break;
            default:
                moverse = false;
            break;
        }
        if(mapa.EsPosicionValida(nuevaPosicionX, nuevaPosicionY) && moverse)
        {
            PosicionX = nuevaPosicionX;
            PosicionY = nuevaPosicionY;
            mapa.RealizarAccionCasilla(this);
        }
    }
}
