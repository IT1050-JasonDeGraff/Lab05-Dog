using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dog
{
    class Dog
    {
        public string Name { get; set; }
        

        // Add Bark() method
   
        public void Bark()
        {
            Console.WriteLine(Name + " is barking...");
        }
        // Add doTrick() method
        public void DoTrick(string trickName)
        {
            Console.WriteLine("{0} is so smart!  {0} is doing a {1}!", Name, trickName);
            Console.ReadLine();
        }


    }
}






