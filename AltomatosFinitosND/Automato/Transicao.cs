using AltomatosFinitosND.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltomatosFinitosND.Automato
{
    class Transicao : iTransicao
    {
        private String nome;
        private iEstado proxEstado;
        private iEstado pai;

        public Transicao(String nome)
        {
            this.nome = nome;
        }
        public void setNome(String nome)
        {
            this.nome = nome;
        }
        public String getNome()
        {
            return this.nome;
        }
        public iEstado getProxEstado()
        {
            return this.proxEstado;
        }
        public void setProxEstado(iEstado estado)
        {
            this.proxEstado = estado;
        }
        public void setPai(iEstado pai)
        {
            this.pai = pai;
        }
        public iEstado getPai()
        {
            return this.pai;
        }
    }
}
