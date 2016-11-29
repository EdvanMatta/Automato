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
        private String nomeTransicao;
        private iEstado proxEstado;
        private iEstado pai;

        public Transicao(String nome) { 
            this.nomeTransicao = nome; 
        }

        public void setNomeTransicao(String nome) { 
            this.nomeTransicao = nome; 
        }

        public String getNomeTransicao() {
            return this.nomeTransicao;
        }

        public iEstado getProxEstado() {
            return this.proxEstado;
        }

        public void setProxEstado(iEstado estado) {
            this.proxEstado = estado;
        }

        public void setPai(iEstado pai) {
            this.pai = pai;
        }

        public iEstado getPai() {
            return this.pai;
        }
    }
}
