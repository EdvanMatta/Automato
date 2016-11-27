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
        private String nome;
        private List<iTransicao> trans = new List<iTransicao>();

        public Estado(String nome)
        {
            this.nome = nome;
        }

        public string getNome() { return nome;}

        public void setNome(string nome) { this.nome = nome;}

        public void addTransicao(iTransicao elem) { this.trans.Add(elem);}

        public void removeTrasicao(iTransicao elem) { this.trans.Remove(elem);}

        public List<iTransicao> getTransicoes() { return this.trans;}

        public bool getFinal() { throw new NotImplementedException();}

        public iTransicao getTrasicao(int index) { throw new NotImplementedException();}
    }
}
