using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltomatosFinitosND.Interface
{
     public interface iAplicacao
    {
         /*public String alfabeto { get; set; }
         public String expressãoRegular { get; set; }*/

        
         void setAlfabeto(String alfa);
         String getAlfabeto();
         void setExpressaoRegular(String ex);
         String getExpressaoRegular();
         iAutomato getAFN(String ex);
         iAutomato getAFD(iAutomato afn);
         List<iEstado> getMatrizAFN();
         List<iEstado> getMatrizAFD();
        
    }
}
