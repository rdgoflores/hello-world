using System;
using System.Threading;

namespace HelloWorld_Game
{
    class MenuPrincipal
    {   
        public static void Main(string [] args)
        {
            FaseUm fu = new FaseUm();
            FaseDois fd = new FaseDois();
            Prompt pt = new Prompt();


            fu.campoum();

            Console.Write("\n\n Seguir para próxima fase [s/n]?     ");
            char escolha = Convert.ToChar(Console.ReadLine());
            Console.Clear();

            if(escolha == 's' || escolha == 'S')
            {
                fd.campodois();
                Console.Write("\n\n     Seu score total foi: " + (fu.xpf1+=fd.xpf2));
                //Console.Write("\n\n     Seu score na fase dois foi: " + fd.xpd);
                Console.Write("\n\n     Até a próxima!  ");
                //Thread.Sleep(2000);
                //Console.Clear();
            }else
            {
                Console.Write("\n\n     Seu score foi: " + fu.xpf1);
                //Console.Write("\n\n     Seu score na fase dois foi: " + fd.xpd);
                Console.Write("\n\n     Até a próxima!  ");
                //Thread.Sleep(2000);
                //Console.Clear();
            }
        }
    }
}