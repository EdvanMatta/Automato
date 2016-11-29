using AltomatosFinitosND.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltomatosFinitosND.Automato
{
    public class OperacaoAdicao : iOperacao
    {
        public void gerarEstados(String nomeTransicao, iAutomato automato)
        {
            int contEstadoInicial, contEstado;
            contEstado = automato.tamanhoListaEstado();
            contEstadoInicial = contEstado;
            

            if (contEstadoInicial > 0)
            {
                contEstado++;

                Estado s0 = new Estado("S" + contEstado); contEstado++;
                Estado s1 = new Estado("S" + contEstado); contEstado++;
                Estado s2 = new Estado("S" + contEstado); contEstado++;

                Estado estado = new Estado("S" + contEstadoInicial);
                Transicao transicao = new Transicao("");
                transicao.setPai(automato.getEstado()[contEstadoInicial - 1]);
                transicao.setProxEstado(estado);
                automato.getEstado()[contEstadoInicial - 1].addTransicao(transicao);

                Transicao t0 = new Transicao("");
                t0.setPai(estado);
                t0.setProxEstado(s0);

                Transicao t1 = new Transicao("");
                t1.setPai(estado);
                t1.setProxEstado(s2);

                estado.addTransicao(t0);

                Transicao t2 = new Transicao(nomeTransicao);
                t2.setPai(s0);
                t2.setProxEstado(s1);
                s0.addTransicao(t2);

                Transicao t3 = new Transicao("");
                t3.setPai(s1);
                t3.setProxEstado(s2);

                Transicao t4 = new Transicao("");
                t4.setPai(s1);
                t4.setProxEstado(s0);

                s1.addTransicao(t3);
                s1.addTransicao(t4);

                automato.addEstado(estado);
                automato.addEstado(s0);
                automato.addEstado(s1);
                automato.addEstado(s2);
            }
            else
            {
                Estado s0 = new Estado("S" + contEstado); contEstado++;
                Estado s1 = new Estado("S" + contEstado); contEstado++;
                Estado s2 = new Estado("S" + contEstado); contEstado++;
                Estado s3 = new Estado("S" + contEstado); contEstado++;

                Transicao t0 = new Transicao("");
                t0.setProxEstado(s1);
                t0.setPai(s0);

                Transicao t1 = new Transicao("");
                t1.setProxEstado(s3);
                t1.setPai(s0);

                s0.addTransicao(t0);

                Transicao t2 = new Transicao(nomeTransicao);
                t2.setPai(s1);
                t2.setProxEstado(s2);

                s1.addTransicao(t2);

                Transicao t4 = new Transicao("");
                t4.setPai(s2);
                t4.setProxEstado(s3);

                Transicao t5 = new Transicao("");
                t5.setPai(s2);
                t5.setProxEstado(s1);

                s2.addTransicao(t4);
                s2.addTransicao(t5);

                automato.addEstado(s0);
                automato.addEstado(s1);
                automato.addEstado(s2);
                automato.addEstado(s3);
            }
        }
    }
}
