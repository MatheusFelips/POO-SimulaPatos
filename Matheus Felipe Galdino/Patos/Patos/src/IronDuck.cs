using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patos.src
{
    public class IronDuck : Duck, IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("Displaying a Iron Duck");
        }

        public void Quack()
        {
            Console.WriteLine("Quack, quack!");
        }
    }
}
