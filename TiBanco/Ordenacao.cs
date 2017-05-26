
namespace TiBanco
{
    class Ordenacao
    {
        internal int[] bubble = new int[100];

        public Ordenacao(int []vetor)
        {
            this.bubble = vetor;
            ordenaBuble(this.bubble, 0,vetor.Length-1);
        }
        public int [] select(int [] vetor)
        {
            int posicao = 0;
            int posicaoMenor = 0;
            int posicaoMaior = 0;
            do
            {
                if (vetor[posicaoMenor] > vetor[posicaoMaior])
                {
                    int aux = vetor[posicaoMenor];
                    vetor[posicaoMenor] = vetor[posicaoMaior];
                    vetor[posicaoMaior] = aux;
                }
                else
                {
                    posicaoMaior++;
                }
            } while (posicao != (vetor.Length - 1));
        }
        private int [] ordenaBuble(int[] vetor, int posicao,int referencia)
        {
            if (referencia == 0) return vetor;
            else
            {
                if(posicao == referencia)
                {
                    referencia -= 1;
                    posicao = 0;
                }
                else
                {
                    int atual = posicao;
                    int proximo = posicao+1;
                    if (vetor[atual] > vetor[proximo])
                    {
                        int posicaoAtual = vetor[proximo];
                        vetor[proximo] = vetor[atual];
                        vetor[atual] = posicaoAtual;
                    }
                    posicao++;
                }
                return ordenaBuble(vetor, posicao, referencia);
            }
        }
    }
}
