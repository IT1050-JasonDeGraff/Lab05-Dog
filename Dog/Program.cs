using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dog
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /*
             *2. a. Scope - It's located in Public.  It shows where the method is called from (). 
             * b. Static vs Non-Static - This is non-static.  Static determines the type of value returned.  
             * c. Return Type - Determines the type of value returned.  This is "double" in this example.
             * d. Method Name - Should make the method self-explanatory.  "get Area: in this example.  
             * e. Parameters - Name and type of parameters.  Parameters only accessible in the method body.  In this example it's "return height * width"
             * 
             * 3. User defined method are customer methods that we write, while Framework methods provide meaningful methods for a platform 
             * or framework.  "Don't reinvent the wheel," try to used framework provided methods whenever possible.  
             * 
             * 4. Static methods relate to a class as a whole, whereas non-static methods are associated with a specific object 
             * (instance) of the class and may manipulate the instance variables of that object( as well as the class's static members). 
             */


            Dog myDog = new Dog();
            myDog.Name = "Milo";

            // To do: uncomment the following lines of code to call the methods
            myDog.Bark();
            myDog.DoTrick("Flip");
        }
    }
}
