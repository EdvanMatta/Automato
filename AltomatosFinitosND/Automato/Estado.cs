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

        public string getNome()
        {
            //throw new NotImplementedException();
            return nome;
        }

        public void setNome(string nome)
        {
            //throw new NotImplementedException();
            this.nome = nome;
        }

        public void addTransicao(iTransicao elem)
        {
            //throw new NotImplementedException();
            this.trans.Add(elem);
        }

        public void removeTrasicao(iTransicao elem)
        {
            //throw new NotImplementedException();
            this.trans.Remove(elem);
        }

        public List<iTransicao> getTransicoes()
        {
            //throw new NotImplementedException();
            return this.trans;
        }

        public bool getFinal()
        {
            throw new NotImplementedException();

        }

        public iTransicao getTrasicao(int index)
        {
            throw new NotImplementedException();
        }
    }
}
