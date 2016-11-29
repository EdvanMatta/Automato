using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltomatosFinitosND.Interface
{
    public interface iTransicao
    {
         void setNomeTransicao(String nome);
         String getNomeTransicao();
         iEstado getPai();
         void setPai(iEstado estado);
         iEstado getProxEstado();
         void setProxEstado(iEstado estado);
    }
}
