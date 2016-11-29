using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltomatosFinitosND.Interface
{
    public interface iEstado
    {
         void addTransicao(iTransicao elem);
         void removeTrasicao(iTransicao elem);
         List<iTransicao> getTransicoes();
         String getNomeEstado();
         void setNomeEstado(String nome);
         Boolean getFinalEstado();
         iTransicao getTrasicao(int index);
    }
}
