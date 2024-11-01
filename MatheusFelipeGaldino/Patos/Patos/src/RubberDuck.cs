using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patos.src
{
    public class RubberDuck : Duck, IQuackable, ISwimminable
    {
        public override void Display()
        {
            Console.WriteLine("Displaying a Rubber Duck");

        }



        public void Quack()
        {
            Console.WriteLine("Quack, quack!");

        }

        public void Swim()
        {            
                Console.WriteLine("The rubber duck is swiming");            
        }
    }
}
