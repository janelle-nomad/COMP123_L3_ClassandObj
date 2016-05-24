using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_L3_ClassandObj
{

    /**
     * This class is the "driver" class of our program
     */
    public class Program
    {
        /**
         *  The main method for our driver class Program
         *  
         *  @method main
         *  @param {string[]} args
         */
       public static void Main(string[] args)
        {
           // Creates a new object of person class, in other words breathes life
           Person person = new Person();

           //Set a value in the name property class
            person.Name = "Jenny";

           // get the Name value and print to console
           Console.WriteLine(person.Name);
           
           
             
        }
    }
}
