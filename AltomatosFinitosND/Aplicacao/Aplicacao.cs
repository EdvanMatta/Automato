using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AltomatosFinitosND.Interface;

namespace AltomatosFinitosND
{
    public class Aplicacao : iAplicacao
    {
        private iAutomato afn;
        private iAutomato afd;

        public Aplicacao(String er)
        {
            this.afn = this.getAFN(er);
            this.afd = this.getAFD(this.afn);
        }

        public void setAlfabeto(string alfa)
        {
 	        throw new NotImplementedException();
        }

        public string getAlfabeto()
        {
 	        throw new NotImplementedException();
        }

        public void setExpressaoRegular(string ex)
        {
 	        throw new NotImplementedException();
        }

        public string getExpressaoRegular()
        {
 	        throw new NotImplementedException();
        }

        public iAutomato getAFN(string ex)
        {
 	        throw new NotImplementedException();
        }

        public iAutomato getAFD(iAutomato afn)
        {
 	        throw new NotImplementedException();
        }

        public List<iEstado> getMatrizAFN()
        {
 	        throw new NotImplementedException();
        }

        public List<iEstado> getMatrizAFD()
        {
 	        throw new NotImplementedException();
        }
    }
}
