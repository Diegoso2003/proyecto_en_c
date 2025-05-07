namespace Proyecto1.Mapa;

public class ConstructorDeMapa
{
    private readonly Random random = new();
    private const int MapaPequeño = 7;
    private const int MapaMediano = 10;
    private const int MapaGrande = 12;
    private const int MenorNumeroCiudades = 3;
    private const int MedioNumeroCiudades = 4;
    private const int MaximoNumeroCiudades = 5;

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
        int r = random.Next(1,4);
        switch(r){
            case 1:
                return MapaPequeño;
            case 2:
                return MapaMediano;
            default:
                return MapaGrande;
        }
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
        int r = random.Next(1,4);
        switch(r)
        {
            case 1:
                return MenorNumeroCiudades;
            case 2:
                return MedioNumeroCiudades;
            default:
                return MaximoNumeroCiudades;
        }
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
