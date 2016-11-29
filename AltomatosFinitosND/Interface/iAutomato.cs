using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltomatosFinitosND.Interface
{
    public interface iAutomato
    {
         void setOperacao(iOperacao oper);
         void addEstado(iEstado estado);
         void removeEstado(iEstado estado);
         int tamanhoListaEstado();
         void gerarEstados(String nomeTrasicao);
         List<iEstado> getEstado();
         void desenha(int largura, int altura);
    }
}
