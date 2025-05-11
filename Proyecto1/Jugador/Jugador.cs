namespace Proyecto1.Jugador;

using Imagen;
public class Jugador
{
    public string Nombre
    {get; set;} = "";
    public int Oro
    {get; set;} = 1000;
    public int PosicionX 
    {get;}
    public int PosicionY
    {get;}
    private readonly string imagen = Imagenes.Jugador.Imagen;

    public string Imagen
    {get{ return imagen; }}

    public void MoverseMapa(Mapa.Mapa mapa)
    {
        ElegirDireccion();
    }

    private void ElegirDireccion()
    {

    }
}
