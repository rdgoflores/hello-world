using System;
using System.Threading;

namespace HelloWorld_Game
{
    public class FaseUm
    {
        public FaseUm(){}

        CampoLimpo cl = new CampoLimpo();
        Prompt pt = new Prompt();
        public int xpf1 = 0;
        
        public void campoum()
        {
            cl.field[8,1] = "*";
            cl.sentence[2,0] = "|   [X] - Obstáculo";
            cl.sentence[3,0] = "|   [#] - XP (obrigatório)";
            cl.sentence[5,0] = "|   [A] - Enquanto";
            cl.sentence[6,0] = "|   [B] - Faça";
            cl.sentence[7,0] = "|   [C] - Falso";
            cl.sentence[8,0] = "|   [D] - For Igual";
            cl.sentence[9,0] = "|   [E] - Ir Para Direita";
            cl.sentence[10,0] = "|   [F] - Ir Para Esquerda";
            cl.sentence[11,0] = "|   [G] - Ir para Frente";
            cl.sentence[12,0] = "|   [H] - Limite";
            cl.sentence[13,0] = "|   [I] - Obstáculo";
            cl.sentence[14,0] = "|   [J] - Se";
            cl.sentence[15,0] = "|   [K] - Verdadeiro";
            cl.sentence[17,0] = "|   Acertos = " + pt.acertos;
            cl.sentence[18,0] = "|   Erros = " + pt.erros;


            pt.linhaDefinida[0] = "g";
            pt.linhaDefinida[1] = "a";
            pt.linhaDefinida[2] = "i";
            pt.linhaDefinida[3] = "d";
            pt.linhaDefinida[4] = "c";
       
            pt.comandoLinha[0] = "Ir para Frente";
            pt.comandoLinha[1] = "Enquanto";
            pt.comandoLinha[2] = "Obstáculo";
            pt.comandoLinha[3] = "For Igual";
            pt.comandoLinha[4] = "Falso";

            pt.y = 5;

            Console.Clear();
            cl.sentence[20,0] = "|   XP = "+ xpf1;
            cl.campolimpo();
            pt.escritos();
            
            for(int n=0; n<5; n++)
            {
                do
                {
                    pt.linhaum();
                    Console.Clear();
                    cl.sentence[17,0] = "|   Acertos = " + pt.acertos;
                    cl.sentence[18,0] = "|   Erros = " + pt.erros;
                    cl.campolimpo();
                    pt.escritos();

                }while(pt.entradaLinha[n] != pt.linhaDefinida[n]);
                pt.i++;
            }

            if(pt.acertos >= 5)
            {
                pt.acertos = 5;
            }          

            xpf1 = (200 - (pt.erros*10));

            if(pt.acertos == 5)
            {
                Thread.Sleep(900);
                Console.Clear();
                cl.field[8,1] = "*";
                
                cl.campolimpo();
                Thread.Sleep(300);

                Console.Clear();
                cl.field[7,1] = "*";
                cl.campolimpo();
                Thread.Sleep(300);

                Console.Clear();
                cl.field[6,1] = "*";
                cl.campolimpo();
                Thread.Sleep(300);

                Console.Clear();
                cl.field[5,1] = "*";
                cl.campolimpo();
                Thread.Sleep(300);

                Console.Clear();
                cl.field[4,1] = "*";
                cl.campolimpo();
                Thread.Sleep(300);

                Console.Clear();
                cl.field[3,1] = "*";
                cl.campolimpo();
                Thread.Sleep(300);

                Console.Clear();
                cl.field[2,1] = "*";
                cl.campolimpo();
                Thread.Sleep(300);

                Console.Clear();
                cl.field[1,1] = "*";
                cl.campolimpo();
                Thread.Sleep(300);

                Console.Clear();
                cl.field[0,1] = "*";
                cl.sentence[20,0] = "|   XP = "+ xpf1;
                cl.campolimpo();
                Thread.Sleep(300);

                Console.WriteLine("         Parabéns! Você Conseguiu \n\n");
            }
        }
    }
}