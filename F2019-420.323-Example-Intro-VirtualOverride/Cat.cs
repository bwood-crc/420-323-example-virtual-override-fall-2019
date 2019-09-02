using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2019_420._323_Example_Intro_VirtualOverride
{
    /// <summary>
    /// This specializes Animal.
    /// </summary>
    class Cat : Animal
    {
        /// <summary>
        /// Overrides from base class.
        /// </summary>
        public override void makeSound()
        {
            Console.WriteLine("Since I am a cat, a specialized animal, I should \"meow.\"");
        }
    }
}
