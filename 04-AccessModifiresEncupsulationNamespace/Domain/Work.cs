using _04_AccessModifiresEncupsulationNamespace.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    internal class Work : Person
    {
        public Work()
        {
            Person person = new Person();
            // public fielde drived class(different assembly) cata bilirik.
            Console.WriteLine(this.name);

            // protected fielde drived class(different assembly) cata bilirik.
            Console.WriteLine(this.name1);

            // internal fielde drived class(different assembly) cata bilmirik.
            //Console.WriteLine(this.name2);

            // private fielde drived class(different assembly) cata bilmirik.
            //Console.WriteLine(this.name3);

            // protected internal fielde drived class(different assembly) cata bilirik.
            Console.WriteLine(this.name4);

            // private protected fielde drived class(different assembly) cata bilmirik.
            //Console.WriteLine(this.name5);
        }
    }
}
