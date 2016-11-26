using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltomatosFinitosND.Interface
{
    public interface iOperacao
    {
        void gerarEstados(String nomeTransicao, iAutomato automato);
    }
}
