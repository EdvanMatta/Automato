using AltomatosFinitosND.Automato;
using AltomatosFinitosND.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltomatosFinitosND
{
    class Program
    {
        private static List<iEstado> estados;

        static void Main(string[] args)
        {
            String afnTeste = "AB*";

            AFN afn = new AFN(afnTeste);

            Console.WriteLine("AFN Estado gerados algoritmo de Thompson da expressão: " + afnTeste);
            Console.WriteLine("Estado inicial: " + afn.getEstadoIni().getNomeEstado());
            Console.WriteLine("Estado final: " + afn.getEstadoFim().getNomeEstado() + "\n");
            estados = afn.getEstado();
            for (int i = 0; i < estados.Count; i++)
            {
                List<iTransicao> t = estados[i].getTransicoes();
                Console.WriteLine(estados[i].getNomeEstado());
         
                for (int x = 0; x < t.Count; x++)
                {
                    Console.WriteLine("Objeto Transito: \n\t\t>>Pai " + t[x].getPai().getNomeEstado());
                    Console.WriteLine("\t\t>>" + t[x].getNomeTransicao());
                    Console.WriteLine("\t\t>><Próx>" + t[x].getProxEstado().getNomeEstado());
                }
            }
            Console.ReadKey();
        }
    }
}
