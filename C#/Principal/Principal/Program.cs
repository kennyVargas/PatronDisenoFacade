using System;

namespace Principal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Facade cliente1 = new Facade("09/10/2020", "01/11/2020", "Argentina", "Brazil");

            Facade cliente2 = new Facade("09/09/2020", "01/12/2020", "Brazil", "Argentina");
            cliente1.buscar();
            cliente2.buscar();

        }
    }
}
