using _04_AccessModifiresEncupsulationNamespace.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    internal class Ndrived
    {
        public Ndrived()
        {
            Person person = new Person();
            // public fielde non-drive class(different assembly) cata bilirik.
            Console.WriteLine(person.name);

            // protected fielde non-drive class(different assembly) cata bilmirik.
            //Console.WriteLine(person.name1);

            // internal fielde non-drive class(different assembly) cata bilmirik.
            //Console.WriteLine(person.name2);

            // private fielde non-drive class(different assembly) cata bilmirik.
            //Console.WriteLine(person.name3);

            // protected internal fielde non-drive class(different assembly) cata bilmirik.
            //Console.WriteLine(person.name4);

            // private protected fielde non-drive class(different assembly) cata bilmirik.
            //Console.WriteLine(person.name5);

        }
    }
}
