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
        protected Char[] expressaoRegular;
        protected String alfabeto;
        protected List<iEstado> estado = new List<iEstado>();

        public String getAlfabeto() { return alfabeto; }

        public void setAlfabeto(String alfabeto) { this.alfabeto = alfabeto; }

        public void addEstado(iEstado estado) { this.estado.Add(estado); }
        
        public void setOperacao(iOperacao oper) { this.operacao = oper; }

        public List<iEstado> getEstado() { return this.estado; }

        public int tamanhoListaEstado() { return this.estado.Count; }
    
        public void removeEstado(iEstado estado){ this.estado.Remove(estado); }

        public String getExpressaoRegular() { return expressaoRegular.ToString(); }

        public void setExpressaoRegular(String expressaoRegular) 
        { this.expressaoRegular = expressaoRegular.ToCharArray(); }

        public void gerarEstados(String nomeTrasicao) { throw new NotImplementedException(); }

        public void desenha(int largura, int altura) { throw new NotImplementedException(); }
    }
}
