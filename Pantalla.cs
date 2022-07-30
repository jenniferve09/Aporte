public class Pantalla : Decorador
{

    public Pantalla(OrdenBase ordenBase) : base(ordenBase) { }
    public virtual string Reparar()
    {
        var repacion = "Reparar pantalla rota";
        return repacion;
    }
}
