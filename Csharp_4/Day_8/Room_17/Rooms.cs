using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_4.Day_8.Room_17
{
     class Rooms
    {

        /*
         * **Room**
             - Properties : `Length`, `Width`, `Height`
             - Function   : `GetVolume()` → calculates room volume
             * 
         */
        //class
        //class is a blueprint of an object.
        //It is a user-defined data type that contains variables, methods, and properties.
        //It is used to create objects.
         
        //Fields
        //Fields are variables that are declared in a class.
        //They are used to store data.
        //They are declared at the class level and can be accessed by all methods in the class.
        //Fields Can Be Deaclared as Any Type of Data Type Like int, double, string, etc.
        //Fields Can Be Deaclared as Public, Private.
        public double _length;
        public double _width;
        public double _height;

        //Function
        //Function is a block of code that performs a specific task.
  
        public double GetVolume()
        {
            return _length * _width ;
        }

    }
}
