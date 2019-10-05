using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jocs
{
    class MenuJocs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tria:\n1. Solitari\n2. Age of empires\n3. Doom\n4. Warcraft\n5. Minecraft\n6. Tropico");
            int opcioEscollida = int.Parse(Console.ReadLine());
            switch (opcioEscollida)
            {
                case 1:
                    Console.WriteLine("El solitari es un joc de cartes");
                    break;
                case 2:
                    Console.WriteLine("Age of empires es un joc d'estrategia ambientat en periodes historics");
                    break;
                case 3:
                    Console.WriteLine("El doom es un joc de matar marcians");
                    break;
                case 4:
                    Console.WriteLine("El warcraft es un joc d'estrategia pre d'orcs i elfs");
                    break;
                case 5:
                    Console.WriteLine("El minecraft es un joc molt quadrat");
                    break;
                case 6:
                    Console.WriteLine("Tropico es un joc on gestiones la teva propia republica bananera");
                    break;
                default:
                    Console.WriteLine("Crec que t'has colat");
                    break;
            }
        }
    }
}
