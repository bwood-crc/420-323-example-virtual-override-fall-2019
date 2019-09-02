using System;

namespace F2019_420._323_Example_Intro_VirtualOverride
{
    /// <summary>
    /// Base class to create animal objects.
    /// </summary>
    class Animal
    {
        /// <summary>
        /// Name of the animal.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Age of the animal.
        /// </summary>
        public string Age { get; set; }

        /// <summary>
        /// This should be overridden.
        /// </summary>
        public virtual void makeSound()
        {
            Console.WriteLine("Cannot make a sound since we don't know what type of animal I am yet.");
        }

    }
}
