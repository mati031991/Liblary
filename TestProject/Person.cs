using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    public class Person
    {
        public string Foranme { get; private set; }
        public string Name { get; private set; }

        public Person()
        {

        }
        public Person(string forname, string name)
        {
            this.Foranme = forname;
            this.Name = name;
        }
    }
}
