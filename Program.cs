class Program
{


    public static void Main(String[] args)
    {

        //telefono #1
        Console.WriteLine("------------------------------------------");
        var telefono = new Dispo1();
        Console.WriteLine(telefono.Reparar());

        var reparacion = new Pantalla(telefono);
        Console.WriteLine(reparacion.Reparar());

        var reparacion2 = new Dañada(telefono);
        Console.WriteLine(reparacion2.Reparar());

        var reparacion3 = new Formatear(telefono);
        Console.WriteLine(reparacion3.Reparar());

        Console.WriteLine(telefono.Software());

        var cargador = new Cargador(telefono);
        Console.WriteLine(cargador.Software());
        Console.WriteLine("------------------------------------------");




        //telefono 2
        Console.WriteLine("");
        Console.WriteLine("------------------------------------------");
        var telefono2 = new Dispo2();
        Console.WriteLine(telefono2.Reparar());

        var reparacion4 = new Dañada(telefono2);
        Console.WriteLine(reparacion4.Reparar());

        var reparacion5 = new Formatear(telefono2);
        Console.WriteLine(reparacion5.Reparar());

        var reparacion6 = new Pantalla(telefono);
        Console.WriteLine(reparacion6.Reparar ());

        Console.WriteLine(telefono2.Software());

        var parlante2 = new Bocina(telefono2);
        Console.WriteLine(parlante2.Software());
        Console.WriteLine("");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("------------------------------------------");


        //telefono 3
        var telefono3 = new Dispo3();
        Console.WriteLine(telefono3.Reparar());

        var reparacion7 = new Dañada(telefono3);
        Console.WriteLine(reparacion7.Reparar());

        var reparacion8 = new Formatear(telefono3);
        Console.WriteLine(reparacion8.Reparar());

        var reparacion9 = new Pantalla(telefono3);
        Console.WriteLine(reparacion9.Reparar());

        Console.WriteLine(telefono3.Software());

        var audifonos3 = new Audifonos(telefono3);
        Console.WriteLine(audifonos3.Software());
        Console.WriteLine("");
        Console.WriteLine("------------------------------------------");
    }
}