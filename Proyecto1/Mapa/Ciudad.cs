namespace Proyecto1.Mapa;

using Proyecto1.Imagen;

public class Ciudad : Casilla
{
    private Personajes.Guerrero[] guerreros = new Personajes.Guerrero[4];
    public Ciudad() : base(Imagenes.Ciudad.Imagen) { CrearGuerreros(); }

    internal override void AccionCasilla(Jugador.Jugador jugador)
    {
        if(!EstaLiberada())
        {
            CurarGuerreros();
        }
        else
        {
            CurarGuerreros(jugador);
        }
    }

    public bool EstaLiberada()
    {
        foreach(Personajes.Guerrero guerrero in guerreros)
        {
            if(guerrero.EstaVivo())
            {
                return false;
            }
        }
        return true;
    }

    private void CurarGuerreros(Jugador.Jugador jugador)
    {

    }

    private void CrearGuerreros()
    {
        for(int i = 0; i < guerreros.Length; i++)
        {
            guerreros[i] = new(new(), "Nombre aleatorio");
        }
    }

    private void CurarGuerreros()
    {

    }
}
