using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patos.src
{
    public class RedHeadDuck : Duck, IQuackable, IFlyable, ISwimminable
    {
        public override void Display()
        {
            Console.WriteLine("Displaying a RedHead Duck");
        }

        public void Fly()
        {
            Console.WriteLine("RedHead Duck is Flying ");
        }

        public void Quack()
        {
            Console.WriteLine("Quack, quack!");
        }

        public void Swim()
        {
            Console.WriteLine("The RedHead duck is swiming");
        }
    }
}
