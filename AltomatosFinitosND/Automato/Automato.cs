using AltomatosFinitosND.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltomatosFinitosND.Automato
{
    public abstract class Automato : iAutomato
    {
        protected iOperacao operacao;
        protected char[] expressaoRegular;
        protected String alfabeto;
        protected List<iEstado> estado = new List<iEstado>();

        public String getAlfabeto()
        {
            return alfabeto;
        }

        public void setAlfabeto(String alfabeto)
        {
            this.alfabeto = alfabeto;
        }

        public void addEstado(iEstado estado)
        {
            //throw new NotImplementedException();
            this.estado.Add(estado);
        }
        
        public void setOperacao(iOperacao oper)
        {
            //throw new NotImplementedException();
            this.operacao = oper;
        }

        public List<iEstado> getEstado()
        {
            //throw new NotImplementedException();
            return this.estado;
        }

        public int getTamanhoEstado()
        {
            //throw new NotImplementedException();
            return this.estado.Count();
        }
    
        public void removeEstado(iEstado estado){
            //throw new NotImplementedException();
            this.estado.Remove(estado);
        }

        public String getExpressaoRegular()
        {
            return expressaoRegular.ToString();
        }

        public void setExpressaoRegular(String expressaoRegular)
        {
            this.expressaoRegular = expressaoRegular.ToCharArray();
        }

        public void gerarEstados(String nomeTrasicao)
        {
            throw new NotImplementedException();
        }

        public void desenha(int largura, int altura)
        {
            throw new NotImplementedException();
        }
    }
}
