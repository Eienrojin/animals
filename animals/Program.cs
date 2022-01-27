using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animals animal = new Animals("Бобик", 6, 54.5);
            Lion lion = new Lion("Алекс", 6, 140.5, 200);
            Dolphin dolphin = new Dolphin("Плавничок", 15, 253.3, 178);
            Bird bird = new Bird("Птица", 4, 0.5, 1000);
            Titmouse titmouse = new Titmouse("Синичка", 5, 0.023, 50, 23);
            Titmouse voidTitmouse = new Titmouse();

            Console.WriteLine(animal.ToString());
            Console.WriteLine(lion.ToString());
            Console.WriteLine(dolphin.ToString());
            Console.WriteLine(bird.ToString());
            Console.WriteLine(titmouse.ToString());
            Console.WriteLine(voidTitmouse.ToString());

            Console.ReadKey();
        }
    }
}
