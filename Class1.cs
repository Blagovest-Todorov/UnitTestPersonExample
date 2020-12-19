using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PeoplesRepo
{
    public class Person
    {
        public Person(string firstname, string lastname, int age)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Age = age;
        }

        public string Firstname { get; set; }
        public string Lastname{ get; set; }
        public int Age{ get; set; }

        
    }
}
