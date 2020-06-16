using System;
using System.Threading;

namespace HelloWorld_Game
{
    public class Prompt
    {
        public Prompt(){}
        
        public string[] linhaDefinida = new string[29];
        
        public string[] entradaLinha = new string[29];

        public string[] comandoLinha = new string[29];

        string [] linhaEscrita = new string[29];

        //public int xpp;

        public int acertos, erros, tentativas = 0;

        public int i = 0;
        public int y = 0;

        public void linhaum()
        {
            Console.Write("\n\nDigite a letra correspondente à linha\n" +
                                (i+1) + ". ");
            entradaLinha[i] = Convert.ToString(Console.ReadLine());
            tentativas++;
            if (entradaLinha[i] == linhaDefinida[i])
            {
                acertos++;
                this.linhaEscrita[i] = this.comandoLinha[i];
            }else
            {
                erros++;
                Console.Write("         Ops, tente novamente");
                Thread.Sleep(500);
            }

            if(i >= y)
            {
                i = 0;
            }
        }
        
        public void escritos()
        {
            for(int p=0; p<y; p++)
            {
                Console.Write("\n{0}. {1}", p+1, linhaEscrita[p]);
            }
        }
    }
}