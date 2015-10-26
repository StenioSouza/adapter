using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Adapter
{
    public interface IPadraoTomada2:IPadrao2
    {
        void Plugar(IPadrao2 _Plugue);

        void Desplugar();
    }
}
