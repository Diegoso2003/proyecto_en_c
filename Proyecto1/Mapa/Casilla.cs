namespace Proyecto1.Mapa;

public abstract class Casilla
{
    private string imagen;

    public Casilla(string imagen)
    {
        this.imagen = imagen;
    }

    public abstract void accionCasilla();
}
