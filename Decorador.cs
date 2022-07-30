using System;
public class Decorador
{
    protected OrdenBase orden;

    public Decorador(OrdenBase orden)
    {
        this.orden = orden;
    }
    public virtual string Software()
    {
        return orden.Software();
    }
    public virtual string Reparar()
    {
        return orden.Reparar();
    }
}
