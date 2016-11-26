using AltomatosFinitosND.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltomatosFinitosND.Automato
{
    public class AFN : Automato
    {
        public AFN(String expresaoRegular)
        {
            this.expressaoRegular = expresaoRegular.ToCharArray();
            this.operarEstados(expresaoRegular);
        }

        public iEstado getEstadoFim()
        {
            return this.estado[(this.estado.Count() - 1)];
        }

        public iEstado getEstadoIni()
        {
            return this.estado[0];
        }
        
        private void operarEstados(String er)
        {
            String termoAux = "";

            char[] expressao = er.ToCharArray();
            char atual, prox;

            this.setOperacao(new OperacaoPadrao());
            
            if(expressao.Length > 2){
                for (int i = 0; i < expressao.Length; i++)
                {
                    atual = expressao[i];
                    if (atual.Equals('('))
                    {
                        termoAux = "";
                        int x;
                        for (x=(i + 1); x < expressao.Length && !(expressao[x].Equals(')')); x++)
                        {
                            termoAux += expressao[x];
                        }
                        i = (i + termoAux.Length);
                        this.operarEstados(termoAux);
                    }
                    else
                    {
                        //Console.WriteLine("valor de i: " + i);
                        //Console.WriteLine("Expressão[i]: " + expressao[i]);
                        //Console.WriteLine("Tamanho de expressao: " + expressao.Length);
                        //Console.ReadKey();
                        prox = expressao[i];
                        switch (prox)
                        {
                            case '+':
                                this.setOperacao(new OperacaoAdicao());
                                i++;
                                break;
                            case '*':
                                this.setOperacao(new OperacaoMultiplicacao());
                                i++;
                                break;
                           // case '|':
                             //   this.setOperacao(new OperacaoPadrao());
                               // break;
                            default:
                                this.setOperacao(new OperacaoPadrao());
                                break;
                        }
                        this.geraEstado("" + atual);
                    }
                }
            }
            else if (expressao.Length == 2)
            {
                this.geraEstado("" + expressao[0]);
                this.geraEstado("" + expressao[1]);
            }
            else
            {
                this.geraEstado("" + expressao[0]);
            }
        }

        public void geraEstado(String nomeTransicao)
        {
            this.operacao.gerarEstados(nomeTransicao, this);
        }

        //public void desenha(int largura, int altura)
    }
}
