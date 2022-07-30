public class Cargador : Decorador
{

    public Cargador(OrdenBase ordenBase) : base(ordenBase) { }

    public override string Software()
    {
        var teclado = "Has agregado el cargador adicional";
        return teclado;
    }
}
