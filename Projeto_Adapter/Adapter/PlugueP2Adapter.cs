using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Adapter
{
    public class PlugueP2Adapter:TomadaP2, IPadrao2
    {
        IPadrao1 plugueP1;

 

    public PlugueP2Adapter(IPadrao1 _PlugueP1)

    {

        plugueP1 = _PlugueP1;

    }

    public string Descricao

    {

        get

        {

            return plugueP1.Nome;

        }

        set

        {

            plugueP1.Nome = value;

        }

    }

 

    public void Run()

    {

        plugueP1.testar();

    }
    }
}
