public class Audifonos  : Decorador
{

    public Audifonos (OrdenBase ordenBase) : base(ordenBase) { }

    public override string Software()
    {
        var teclado = "Audifonos agregado";
        
        return teclado;
    }
}
