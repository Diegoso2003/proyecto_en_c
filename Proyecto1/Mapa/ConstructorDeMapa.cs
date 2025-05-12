namespace Proyecto1.Mapa;

public class ConstructorDeMapa
{
    private readonly Random random = new();
    private readonly int[] TamañoMapa = [7, 10, 12];
    private readonly int[] NumeroCiudades = [3, 4, 5];

    private readonly Casilla[,] casillas;

    public ConstructorDeMapa()
    {
        int tamaño = CalcularTamaño();
        casillas = new Casilla[tamaño, tamaño];
        LlenarCasillas();
    }

    public Casilla[,] Casillas ()
    {
        return casillas;
    }

    private int CalcularTamaño()
    {
        return TamañoMapa[random.Next(0, TamañoMapa.Length)];
    }

    private void LlenarCasillas()
    {
        ColocarCiudades();
        Tienda tienda = new();
        ColocarCasilla(tienda);
        Posada posada = new();
        ColocarCasilla(posada);
        ColocarEnemigos();
    }

    private void ColocarCiudades()
    {
        int ciudades = CalcularNumeroCiudades();
        do
        {
            Ciudad ciudad = new();
            ColocarCasilla(ciudad);
            ciudades--;
        }
        while(ciudades > 0);
    }

    private void ColocarEnemigos()
    {
        do
        {
            int r = random.Next(1,3);
            Casilla casilla;
            if(r == 1)
            {
                casilla = new CasillaEnemigosFuertes();
            }
            else
            {
                casilla = new CasillaEnemigosDebiles();
            }
            ColocarCasilla(casilla);
            
        }
        while(!MapaLLeno());
    }

    private bool MapaLLeno()
    {
        foreach(Casilla casilla in casillas)
        {
            if(casilla == null)
            {
                return false;
            }
        }
        return true;
    }

    private int CalcularNumeroCiudades()
    {
        return NumeroCiudades[random.Next(1,NumeroCiudades.Length)];
    }

    private void ColocarCasilla(Casilla casilla)
    {
        int filas = casillas.GetLength(0);
        int columnas = casillas.GetLength(1);
        int aleatorioFilas;
        int aleatorioColumnas;
        do
        {
            aleatorioFilas = random.Next(0, filas);
            aleatorioColumnas = random.Next(0, columnas);
        }
        while(casillas[aleatorioFilas, aleatorioColumnas] != null);
        casillas[aleatorioFilas, aleatorioColumnas] = casilla;
    }
}
