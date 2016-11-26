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
         String getNome();
         void setNome(String nome);
         Boolean getFinal();
         iTransicao getTrasicao(int index);
    }
}
