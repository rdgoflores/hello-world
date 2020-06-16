using System;
using System.Threading;

namespace HelloWorld_Game
{
    public class Croqui
    {
        public Croqui (){}

        public void croqui()
        {
          Console.Clear();
          Console.Write(       "                                                    |"+"                          "+                          
                             "\n                                                    |"+"                          "+
                          "\n       |     |     |     |"+"                          |"+"                          "+"[X] - Obstáculo"+ 
                          "\n     B |=====|=====|=====|"+"                          |"+"                          "+"[1] - Indicativo de Obstáculo"+
                          "\n       |     |     |     |"+"                          |"+"                          "+"[!] - Experiência"+ 
                          "\n       |-----|-----|-----|"+"                          |"+"                          "+"[*] - Jogador"+
                          "\n       |  !  |     |     |"+"                          |"+"                          "+
                          "\n       |-----|-----|-----|"+"                          |"+"                          "+
                          "\n       |     |     |     |"+"                          |"+"                          "+ 
                          "\n       |-----|-----|-----|"+"                          |"+
                          "\n       |     |     |  X  |"+"                          |"+ 
                          "\n       |-----|-----|-----|"+"                          |"+
                          "\n       |     |     |  1  |"+"                          |"+ 
                          "\n       |-----|-----|-----|"+"                          |"+
                          "\n       |     |     |     |"+"                          |"+  
                          "\n       |-----|-----|-----|"+"                          |"+
                          "\n       |     |     |     |"+"                          |"+"                          "+"Energia = 100%"+ 
                          "\n     A |=====|=====|=====|"+"                          |"+
                          "\n       |     |     |  *  |"+"                          |"+
                             "\n                                                    |"+
          "\n==========================================================================================================================================");
          
          /*Thread.Sleep(5000);
          Console.Clear();

          Console.Write("  \n       |     |     |     |"+
                          "\n     B |=====|=====|=====|"+
                          "\n       |     |     |     |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |     |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |     |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |  X  |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |  #  |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |     |"+  
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |  *  |"+ 
                          "\n     A |=====|=====|=====|"+
                          "\n       |     |     |  *  |"+
                          "\n"+ 
                          "\n=================================");
          
          Thread.Sleep(500);
          Console.Clear();

          Console.Write("  \n       |     |     |     |"+
                          "\n     B |=====|=====|=====|"+
                          "\n       |     |     |     |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |     |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |     |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |  X  |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |  #  |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |  *  |"+  
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |  *  |"+ 
                          "\n     A |=====|=====|=====|"+
                          "\n       |     |     |  *  |"+
                          "\n"+ 
                          "\n=================================");
          
          Thread.Sleep(500);
          Console.Clear();

          Console.Write("  \n       |     |     |     |"+
                          "\n     B |=====|=====|=====|"+
                          "\n       |     |     |     |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |     |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |     |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |  X  |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |  *  |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |  *  |"+  
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |  *  |"+ 
                          "\n     A |=====|=====|=====|"+
                          "\n       |     |     |  *  |"+
                          "\n"+ 
                          "\n=================================");
          
          Thread.Sleep(500);
          Console.Clear();

          Console.Write("  \n       |     |     |     |"+
                          "\n     B |=====|=====|=====|"+
                          "\n       |     |     |     |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |     |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |     |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |  X  |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |  *  |  *  |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |  *  |"+  
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |  *  |"+ 
                          "\n     A |=====|=====|=====|"+
                          "\n       |     |     |  *  |"+
                          "\n"+ 
                          "\n=================================");
          
          Thread.Sleep(500);
          Console.Clear();

          Console.Write("  \n       |     |     |     |"+
                          "\n     B |=====|=====|=====|"+
                          "\n       |     |     |     |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |     |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |     |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |  *  |  X  |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |  *  |  *  |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |  *  |"+  
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |  *  |"+ 
                          "\n     A |=====|=====|=====|"+
                          "\n       |     |     |  *  |"+
                          "\n"+ 
                          "\n=================================");
          
          Thread.Sleep(500);
          Console.Clear();

          Console.Write("  \n       |     |     |     |"+
                          "\n     B |=====|=====|=====|"+
                          "\n       |     |     |     |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |     |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |  *  |     |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |  *  |  X  |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |  *  |  *  |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |  *  |"+  
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |  *  |"+ 
                          "\n     A |=====|=====|=====|"+
                          "\n       |     |     |  *  |"+
                          "\n"+ 
                          "\n=================================");
          
          Thread.Sleep(500);
          Console.Clear();

          Console.Write("  \n       |     |     |     |"+
                          "\n     B |=====|=====|=====|"+
                          "\n       |     |     |     |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |  *  |     |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |  *  |     |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |  *  |  X  |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |  *  |  *  |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |  *  |"+  
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |  *  |"+ 
                          "\n     A |=====|=====|=====|"+
                          "\n       |     |     |  *  |"+
                          "\n"+ 
                          "\n=================================");
          
          Thread.Sleep(500);
          Console.Clear();

          Console.Write("  \n       |     |     |     |"+
                          "\n     B |=====|=====|=====|"+
                          "\n       |     |  *  |     |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |  *  |     |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |  *  |     |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |  *  |  X  |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |  *  |  *  |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |  *  |"+  
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |  *  |"+ 
                          "\n     A |=====|=====|=====|"+
                          "\n       |     |     |  *  |"+
                          "\n"+ 
                          "\n=================================");
          
          Thread.Sleep(500);
          Console.Clear();

          Console.Write("  \n       |     |  *  |     |"+
                          "\n     B |=====|=====|=====|"+
                          "\n       |     |  *  |     |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |  *  |     |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |  *  |     |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |  *  |  X  |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |  *  |  *  |"+ 
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |  *  |"+  
                          "\n       |-----|-----|-----|"+
                          "\n       |     |     |  *  |"+ 
                          "\n     A |=====|=====|=====|"+
                          "\n       |     |     |  *  |"+
                          "\n"+ 
                          "\n=================================");
          
          Thread.Sleep(500);
          Console.Clear();*/                                                                              

        }
    }
}


/*do
            {
                Console.Clear();
                fum.campoum();
                Console.WriteLine("\nEscreva seu Código Aqui:\n");
                
                
                Console.Write("1. ");
                linha1 = Convert.ToChar(Console.ReadLine());
                if (linha1 == 'a' || linha1 == 'A')
                {
                    xp += 20;
                    cl.sentence[18,0] = "|   XP = "+ xp;
                    fum.campoum();
                }else
                {
                    xp = 0;
                    cl.sentence[18,0] = "|   XP = "+ xp;
                    fum.campoum();
                }
                
                Console.Write("2. ");
                linha2 = Convert.ToChar(Console.ReadLine());
                if (linha2 == 'a' || linha2 == 'I')
                {
                    xp += 20;
                    cl.sentence[18,0] = "|   XP = "+ xp;
                    fum.campoum();
                }else
                {
                    xp = 0;
                    cl.sentence[18,0] = "|   XP = "+ xp;
                    fum.campoum();
                } 
                
                Console.Write("3. ");
                linha3 = Convert.ToChar(Console.ReadLine());
                if (linha3 == 'a' || linha3 == 'D')
                {
                    xp += 20;
                    cl.sentence[18,0] = "|   XP = "+ xp;
                    fum.campoum();
                }else
                {
                    xp = 0;
                    cl.sentence[18,0] = "|   XP = "+ xp;
                    fum.campoum();
                }
                
                Console.Write("4. ");
                linha4 = Convert.ToChar(Console.ReadLine());
                if (linha4 == 'a' || linha4 == 'C')
                {
                    xp += 20;
                    cl.sentence[18,0] = "|   XP = "+ xp;
                    fum.campoum();
                }else
                {
                    xp = 0;
                    cl.sentence[18,0] = "|   XP = "+ xp;
                    fum.campoum();
                }
                
                Console.Write("5. ");
                linha5 = Convert.ToChar(Console.ReadLine());
                if (linha5 == 'a' || linha5 == 'G')
                {
                    xp += 20;
                    cl.sentence[18,0] = "|   XP = "+ xp;
                    fum.campoum();
                }else
                {
                    xp = 0;
                    cl.sentence[18,0] = "|   XP = "+ xp;
                    fum.campoum();
                }

                if (xp == 0)
                {
                    Console.WriteLine("     \nTente novamente");
                    Thread.Sleep(700);
                }

            }while(xp != 100);*/





            /*Console.WriteLine("\n         Escreva seu Código aqui: \n");
                
                Console.Write("1. ");
                linha1 = Convert.ToString(Console.ReadLine());
                if (linha1 == "a" )
                {
                    xp += 20;
                    Console.Write("1. teste1");
                }

                Console.Write("2. ");
                linha1 = Convert.ToString(Console.ReadLine());
                if (linha2 == "b" )
                {
                    xp += 20;
                    Console.Write("2. teste2");
                }*/
















                               


                




        //}

        //public void faseum()
        //{
            //xp += 23;
            
            //FaseUm fum = new FaseUm();
            //cl.sentence[18,0] = "|   XP = " + xp;
            //fum.campoum();
            

            /*Console.WriteLine("\n         Escreva seu Código aqui: \n");

            Console.Write("1. ");
            linha1 = Convert.ToString(Console.ReadLine());
            if (linha1 == "a" )
            {
                Console.Clear();
                this.xp += 20;
                fum.campoum();
                Console.Write("1. teste1");
            }
*/





/*pt.linhadois();
                if(pt.xpp > 100)
                {
                    pt.xpp = 0;
                }

                if(pt.xpp == 100)
                {
                    over = true;
                }
                Console.Clear();
                cl.sentence[18,0] = "|   XP = "+ pt.xpp;
                cl.campolimpo();
                pt.escritos();*/   