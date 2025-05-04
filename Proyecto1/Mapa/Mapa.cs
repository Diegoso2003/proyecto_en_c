namespace Proyecto1.Mapa;

public class Mapa
{
    private Casilla[,] casillas;

    public Mapa()
    {
        ConstructorDeMapa constructor = new ConstructorDeMapa();
        casillas = constructor.ObtenerCasillas();
    }
 
}
