using System;

namespace cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            string frasedigitada, frasecomdislalia;
            Console.WriteLine("Digite uma flase: ");
            frasedigitada = Console.ReadLine();

            frasecomdislalia = frasedigitada.Replace("r", "l").Replace("R","L");

            Console.WriteLine(frasecomdislalia);


        }
    }
}
