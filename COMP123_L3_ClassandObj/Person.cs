using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_L3_ClassandObj
{

    /**
     * This class defines a generic person
     * 
     * @class Person
     * @field _name {string}
     */
   public class Person
    {
        // PRIVATE INSTANCE VARIABLES ***********************
        // all private variable will have an underscore in the beginning*

        private string _name;

        // PUBLIC PROPERTIES ***********************
        /**
         *  This is a peroperty for our _name field
         *  
         *  @property {string} Name
         */
        public string Name
       {
           // getters get data 
           // setters set the value of data inside the class

           get { return this._name; }

           // If i only have a getter it turns the data into a read only property

           set { this._name = value; }
       }
        /**
             * @ This is the default constructor for the person class
             * 
             * @ Constructor Person
        */
        public Person()
        {
            this._name = "Error: Unknown name!";
        }
    }

}
