using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame
{
    internal class Program
    {
        private static readonly Random random = new Random();
        static void Main(string[] args)
        {
            Card card = new Card((Values)random.Next(1, 14), (Suits)random.Next(4));
            Console.WriteLine(card.Name);
            Console.WriteLine("Press any key to exit");
            char key = Console.ReadKey().KeyChar;
        }
    }
}
