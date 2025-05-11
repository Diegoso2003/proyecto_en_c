namespace Proyecto1.Mapa;

public class Mapa
{
    private Casilla[,] casillas;

    public Mapa()
    {
        ConstructorDeMapa constructor = new ConstructorDeMapa();
        casillas = constructor.Casillas();
    }

    public void MostrarMapa(Jugador.Jugador jugador)
    {
        for(int i = 0; i < casillas.GetLength(0); i++)
        {
            for(int j = 0; j < casillas.GetLength(1); j++)
            {
                if(jugador.PosicionX == i && jugador.PosicionY == j)
                {
                    Console.Write(jugador.Imagen);
                }
                else
                {
                    Console.Write(casillas[i,j].Imagen);
                }
            }
            Console.WriteLine();
        }
    }

    public bool MapaLiberado()
    {
        return false;
    }
 
}
