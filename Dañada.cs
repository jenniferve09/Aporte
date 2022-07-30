public class Dañada : Decorador
{

    public Dañada (OrdenBase ordenBase) : base(ordenBase) { }
    public virtual string Reparar()
    {
        var repacion = "la reparacion del telefono se ha completado completo.";
        return repacion;
    }
}
