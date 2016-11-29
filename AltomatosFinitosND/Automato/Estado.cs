using AltomatosFinitosND.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltomatosFinitosND.Automato
{
    public class Estado : iEstado
    {
        private String nomeEstado;
        private List<iTransicao> trans = new List<iTransicao>();

        public Estado(String nome)
        {
            this.nomeEstado = nome;
        }

        public string getNomeEstado() { return nomeEstado;}

        public void setNomeEstado(string nome) { this.nomeEstado = nome;}

        public void addTransicao(iTransicao elem) { this.trans.Add(elem);}

        public void removeTrasicao(iTransicao elem) { this.trans.Remove(elem);}

        public List<iTransicao> getTransicoes() { return this.trans;}

        public bool getFinalEstado() { throw new NotImplementedException();}

        public iTransicao getTrasicao(int index) { throw new NotImplementedException();}
    }
}
