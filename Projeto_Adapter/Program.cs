using System;

namespace Projeto_Adapter
{
    public class Program
    {
static void Main(string[] args)

    {
        TomadaP1 Tomada1 = new TomadaP1();

        TomadaP2 Tomada2 = new TomadaP2();

        PlugueP1 PlugueP1 = new PlugueP1();

        PlugueP2 PlugueP2 = new PlugueP2();

        PlugueP1Adapter plugueP1AdapterP2 = new PlugueP1Adapter(PlugueP2);

        PlugueP2Adapter plugueP2AdapterP1 = new PlugueP2Adapter(PlugueP1);

    

        Console.WriteLine("<  Padrão Adapter  > ");
        Console.WriteLine("Testando tomadas e plugs padrões: \n");

       Tomada1.Conectar(PlugueP1);

       Tomada1.testar();

        Tomada1.Desconectar();

        Tomada1.testar();



        Tomada2.Plugar(PlugueP2);

        Tomada2.Run();

        Tomada2.Desplugar();

        Tomada2.Run();

        Console.Write("\n\n Press <ENTER> to next...");

        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("<  Padrão Adapter  > ");
        Console.WriteLine("Testando tomadas com plugs adaptados (usando padrao adpter): \n");

        Tomada1.Conectar(new PlugueP1Adapter(PlugueP2));
        Tomada1.testar();
        Tomada1.Desconectar();
        Tomada1.testar();

        Tomada2.Plugar(new PlugueP2Adapter(PlugueP1));
        Tomada2.Run();
        Tomada2.Desplugar();
        Tomada2.Run();

        Console.Write("\n\n Press <ENTER> to close...");
        Console.ReadKey();

 

    }

    }

    }

