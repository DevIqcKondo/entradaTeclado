using System;

namespace entradaTeclado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor=ConsoleColor.Red;
            float idade = 0;
            Console.WriteLine("Qual é sua idade ?");
		    idade = float.Parse(Console.ReadLine());
            if(idade>=50){
                Console.ForegroundColor=ConsoleColor.Yellow;
              Console.WriteLine(" Está ficando velho! ");
            }else if(idade<=1){
                Console.ForegroundColor=ConsoleColor.Blue;
             Console.WriteLine("Ainda é um bebê ");
            } 
            else if(idade==19){
                Console.ForegroundColor=ConsoleColor.DarkMagenta;
              Console.WriteLine("Eu também tenho "+idade+" anos!");
            }
             else{
                 Console.ForegroundColor=ConsoleColor.Green;
                 Console.WriteLine("Ainda está jovem!");
             }
             Console.ResetColor();
        }
    } 
    } 

