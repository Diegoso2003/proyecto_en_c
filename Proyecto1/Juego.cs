namespace Proyecto1;

public class Juego
{
    private Mapa.Mapa mapa = new();
    private bool finJuego = false;
    private Jugador.Jugador jugador = new();
    public void IniciarJuego()
    {
        finJuego = false;
        PedirDatos();
        do
        {
            ImprimirInformacion();
            mapa.MostrarMapa(jugador);
            ElegirOpcion();
            Console.Clear();
        }
        while(!finJuego && !mapa.MapaLiberado());
        FinalizarJuego();
    }

    private void ElegirOpcion()
    {
        string? opcion = Console.ReadLine();
        if(opcion != null)
        {
            switch(opcion)
            {
                case "E":
                    //realizar la opcion de finalizar juego
                break;
                default:
                    jugador.MoverseMapa(mapa);
                break;
            }
        }
    }

    private void PedirDatos()
    {
        string? nombre = null;
        do
        {
            Console.WriteLine("Ingrese el nombre de la partida");
            nombre = Console.ReadLine();
        }
        while(nombre == null);
        jugador.Nombre = nombre;
    }

    private void ImprimirInformacion()
    {
        Console.WriteLine("Ingresa W, A, S, D para poder moverte por el mapa");
        Console.WriteLine("Ingresa E para finalizar la partida");
        Console.WriteLine($"Tienda: {Imagen.Imagenes.Tienda.Imagen}");
        Console.WriteLine($"Ciudad conquistada: {Imagen.Imagenes.Ciudad.Imagen}");
        Console.WriteLine($"Ciudad liberada: {Imagen.Imagenes.CiudadLiberada.Imagen}");
        Console.WriteLine($"Tu: {Imagen.Imagenes.Jugador.Imagen}");
    }
    public void FinalizarJuego()
    {
        GuardarReporte();
        Console.WriteLine("1 para iniciar una nueva partida");
        Console.WriteLine("2 para mirar los reportes");
        Console.WriteLine("cualquier otra cosa para finalizar el programa");
        string? opcion = Console.ReadLine();
        if(opcion != null )
        {
            opcion = opcion.Trim();
            switch(opcion)
            {
                case "1":
                    mapa = new();
                    jugador = new();
                    IniciarJuego();
                    break;
                case "2":
                    break;
                default:
                    break;
            }
        }
    }

    private void GuardarReporte()
    {

    }
}
