using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto_Adapter
{
   public class TomadaP2:IPadraoTomada2
    {
       public String Descricao { get; set; }

    IPadrao2 Plugue;

 

    public TomadaP2()

    {

        Descricao = "TomadaP2";

    }

 

    public void Run()

    {

        if (Plugue != null)

        {

            Console.WriteLine("{0} está com o {1} conectado!", Descricao, Plugue.Descricao);

            Plugue.Run();

        }

        else

        {

            Console.WriteLine("{0} está desconectado!\n", Descricao);

        }

    }

 

    public void Plugar(IPadrao2 _Plugue)

    {

        Plugue = _Plugue;

        Console.WriteLine("{0} conectado!", Plugue.Descricao);

    }

 

    public void Desplugar()

    {

        Plugue = null;

    }

}
    }

