using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2019_420._323_Example_Intro_VirtualOverride
{
    class Program
    {
        /// <summary>
        /// Demo program to show how virtual and override works.
        /// Please study the different between "abstract" and virtual.
        /// 
        /// Try changing the base class to abstract and observe the results.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var a1 = new Animal();
            a1.makeSound();

            var a2 = new Cat();
            a2.makeSound();
        }
    }
}
