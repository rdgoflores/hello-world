using System;
using System.Threading;

namespace HelloWorld_Game
{
    public class FaseDois
    {
        public FaseDois(){}

        CampoLimpo cl = new CampoLimpo();
        Prompt pt = new Prompt();
        FaseUm fum = new FaseUm();
        public int xpf2 = 0;

        //public int xpd = 0;
        
        public void campodois()
        {
            cl.field[8,1] = "*";
            cl.field[5,1] = "X";
            cl.field[2,0] = "#";
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
            pt.linhaDefinida[5] = "j";
            pt.linhaDefinida[6] = "i";
            pt.linhaDefinida[7] = "d";
            pt.linhaDefinida[8] = "k";
            pt.linhaDefinida[9] = "f";
            pt.linhaDefinida[10] = "a";
            pt.linhaDefinida[11] = "h";
            pt.linhaDefinida[12] = "d";
            pt.linhaDefinida[13] = "c";
            pt.linhaDefinida[14] = "j";
            pt.linhaDefinida[15] = "h";
            pt.linhaDefinida[16] = "d";
            pt.linhaDefinida[17] = "k";
            pt.linhaDefinida[18] = "e";
            pt.linhaDefinida[19] = "a";
            pt.linhaDefinida[20] = "i";
            pt.linhaDefinida[21] = "d";
            pt.linhaDefinida[22] = "c";

            pt.comandoLinha[0] = "Ir para Frente";
            pt.comandoLinha[1] = "Enquanto";
            pt.comandoLinha[2] = "Obstáculo";
            pt.comandoLinha[3] = "For Igual";
            pt.comandoLinha[4] = "Falso";
            pt.comandoLinha[5] = "Se";
            pt.comandoLinha[6] = "Obstáculo";
            pt.comandoLinha[7] = "For Igual";
            pt.comandoLinha[8] = "Verdadeiro";
            pt.comandoLinha[9] = "Ir Para Esquerda";
            pt.comandoLinha[10] = "Enquanto";
            pt.comandoLinha[11] = "Limite";
            pt.comandoLinha[12] = "For Igual";
            pt.comandoLinha[13] = "Falso";
            pt.comandoLinha[14] = "Se";
            pt.comandoLinha[15] = "Limite";
            pt.comandoLinha[16] = "For Igual";
            pt.comandoLinha[17] = "Verdadeiro";
            pt.comandoLinha[18] = "Ir Para Direita";
            pt.comandoLinha[19] = "Enquanto";
            pt.comandoLinha[20] = "Obstáculo";
            pt.comandoLinha[21] = "For Igual";
            pt.comandoLinha[22] = "Falso";

            pt.y = 23;

            Console.Clear();
            cl.sentence[20,0] = "|   XP = "+ fum.xpf1;
            //cl.sentence[20,0] = "|   XP = " + 0;
            cl.campolimpo();
            pt.escritos();

            for(int n=0; n<23; n++)
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

            xpf2 += (200 - (pt.erros*10) + 50); 
 
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
                cl.field[6,0] = "*";
                cl.campolimpo();
                Thread.Sleep(300);

                Console.Clear();
                cl.field[5,0] = "*";
                cl.campolimpo();
                Thread.Sleep(300);

                Console.Clear();
                cl.field[4,0] = "*";
                cl.campolimpo();
                Thread.Sleep(300);

                Console.Clear();
                cl.field[3,0] = "*";
                cl.campolimpo();
                Thread.Sleep(300);

                Console.Clear();
                cl.field[2,0] = "*";
                cl.campolimpo();
                Thread.Sleep(300);

                Console.Clear();
                cl.field[1,0] = "*";
                cl.campolimpo();
                Thread.Sleep(300);

                Console.Clear();
                cl.field[0,0] = "*";
                cl.sentence[20,0] = "|   XP = " + xpf2;
                cl.campolimpo();
                Thread.Sleep(300);

                Console.WriteLine("         Parabéns! Você Conseguiu \n\n");
            }           
        }
    }
}