using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patos.src
{
    public class MallardDuck : Duck, IFlyable, IQuackable, ISwimminable
    {
        public override void Display()
        {
            Console.WriteLine("Displaying a Mallard Duck");
        }

        public void Fly()
        {
            Console.WriteLine("Mallard Duck is Flying ");
        }

        public void Quack()
        {
            Console.WriteLine("Quack, quack!");
        }

        public void Swim()
        {
            Console.WriteLine("The Mallard duck is swiming");
        }
    }
}
