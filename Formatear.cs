public class Formatear : Decorador
{

    public Formatear(OrdenBase ordenBase) : base(ordenBase) { }
    public virtual string Reparar()
    {
        var repacion = "Formato completado";
        return repacion;
    }
}
