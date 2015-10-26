using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Adapter
{
    public interface IPadraoTomada1: IPadrao1
    {
        void Conectar(IPadrao1 _Plugue);

        void Desconectar();
    }
}
