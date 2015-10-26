using Projeto_Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto_Adapter
{
    public class TomadaP1 : IPadraoTomada1
    {

        public String Nome { get; set; }

        IPadrao1 Plugue;

         public TomadaP1()

    {

        Nome = "TomadaP1";

    }
        public void testar()
        {

            if (Plugue != null)
            {

                Console.WriteLine("{0} está com o {1} conectado!", Nome , Plugue.Nome);

                Plugue.testar();

            }

            else
            {

                Console.WriteLine("{0} está desconectado! \n", Nome);

            }

        }



        public void Conectar(IPadrao1 _Plugue)
        {

            Plugue = _Plugue;

            Console.WriteLine("{0} conectado!", Plugue.Nome);

        }



        public void Desconectar()
        {

            Plugue = null;

        }

    }
}


