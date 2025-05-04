namespace Proyecto1.Mapa;

public class Ciudad : Casilla
{
    private string ciudadLiberada = "🏯";

    public Ciudad() : base("🏰") { }

    public override void accionCasilla()
    {
        throw new NotImplementedException();
    }
}
