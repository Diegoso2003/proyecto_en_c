namespace Proyecto1.Imagen;

public class Imagenes
{
    public string Imagen
    {get; private set;}
    private Imagenes(string imagen)
    {
        Imagen = imagen;
    }
    public static readonly Imagenes CasillaEnemigosDebiles = new("🟦");
    public static readonly Imagenes CasillaEnemigosFuertes = new("🟥");
    public static readonly Imagenes Ciudad = new("🏰");
    public static readonly Imagenes CiudadLiberada = new("🏯");
    public static readonly Imagenes Posada = new("🏨");
    public static readonly Imagenes Tienda = new("🏪");
    public static readonly Imagenes Jugador = new("🧙");
}
