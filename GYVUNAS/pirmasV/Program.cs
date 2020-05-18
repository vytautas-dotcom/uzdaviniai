using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmasV
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Sunys");
            dog.Bark();
            Console.WriteLine(dog.lojimuSk);
            dog.Greet();

            Cat cat = new Cat("Kates");
            cat.Meow();
            cat.Meow();
            Console.WriteLine(cat.miaukimuSk);
            cat.Greet();

            Lizard lizard = new Lizard("Driezai");
            lizard.CatchFly();
            lizard.CatchFly();
            lizard.CatchFly();
            Console.WriteLine(lizard.musiuSk);
            lizard.Greet();

            Console.ReadKey();
        }
    }
}
