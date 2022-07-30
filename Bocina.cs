public class Bocina : Decorador
{

    public Bocina(OrdenBase ordenBase) : base(ordenBase) { }

    public override string Software()
    {
        var teclado = orden.Software();
        Console.WriteLine("Has agregado el parlante adicional");
        return teclado;
    }
}
