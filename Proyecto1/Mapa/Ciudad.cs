namespace Proyecto1.Mapa;
using Proyecto1.Imagen;

public class Ciudad : Casilla
{
    public Ciudad() : base(Imagenes.Ciudad.Imagen) { }

    public override void accionCasilla()
    {
        throw new NotImplementedException();
    }
}
