using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiBanco
{
    class ManipulaArquivo
    {
        string caminho = "c:/Users/bruno/Google drive/puc/12017/aed/TiBanco/ordena.txt";
        string final= "c:/Users/bruno/Desktop/final.txt";
        internal int[] vetor = new int[132];

        public ManipulaArquivo()
        {
            importa();
        }
        internal void escreve(int []entrada)
        {
            StreamWriter escreve = new StreamWriter(final);
            int posicao = 0;
            do
            {
                escreve.WriteLine(entrada[posicao]);
                posicao++;
            } while (posicao != entrada.Length - 1);
            escreve.Close();
        }
        void importa()
        {
            StreamReader leitor = new StreamReader(caminho);
            int posicao = 0;
            string linhaAtual = leitor.ReadLine();
            do
            {
                vetor[posicao] = int.Parse(linhaAtual);
                posicao++;
                linhaAtual = leitor.ReadLine();
            } while (posicao != (vetor.Length - 1));
            leitor.Close();
        }
    }
}

