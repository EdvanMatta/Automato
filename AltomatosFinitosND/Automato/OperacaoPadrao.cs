using AltomatosFinitosND.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltomatosFinitosND.Automato
{
    public class OperacaoPadrao : iOperacao
    {
        public void gerarEstados(String nomeTransicao, iAutomato automato)
        {
            int contEstado, contEstadoincial;
            contEstado = automato.tamanhoListaEstado();
            contEstadoincial = contEstado;

            if (contEstadoincial > 0)
            {
                    contEstado++;
                    Transicao tConector = new Transicao("");
                    tConector.setPai(automato.getEstado()[contEstadoincial - 1]);
                    Estado sConector = new Estado("S" + contEstadoincial);
                    tConector.setProxEstado(sConector);

                    automato.getEstado()[contEstadoincial - 1].addTransicao(tConector);

                    Estado s0 = new Estado("S" + contEstado);

                    Transicao t0 = new Transicao(nomeTransicao);
                    t0.setPai(sConector);
                    t0.setProxEstado(s0);

                    sConector.addTransicao(t0);

                    automato.addEstado(sConector);
                    automato.addEstado(s0);
                }
            else
            {
                Estado s0 = new Estado("S" + contEstado); contEstado++;
                Estado s1 = new Estado("S" + contEstado);

                Transicao t0 = new Transicao(nomeTransicao);
                t0.setPai(s0);
                t0.setProxEstado(s1);
                s0.addTransicao(t0);

                automato.addEstado(s0);
                automato.addEstado(s1);
            }
        }
    }
}
