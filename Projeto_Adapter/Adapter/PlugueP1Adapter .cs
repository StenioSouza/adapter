using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Adapter
{
    public class PlugueP1Adapter:TomadaP1, IPadrao1
    {
        IPadrao2 plugueP2;

 

    public PlugueP1Adapter(IPadrao2 _PlugueP2)

    {

        plugueP2 = _PlugueP2;

   }

    public string Nome

    {

        get

        {

            return plugueP2.Descricao;

        }

        set

        {

            plugueP2.Descricao = value;

        }

    }

 

    public void testar()

    {

        plugueP2.Run();

    }
    }
}
