using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public class Human
    {
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Adress { get; set; }
        public string School { get; set; }
        public string Mother { get; set; }
        public string Father { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Nationality { get; set; }
        public string FirstName { get; set; }

        public Human Clone()
        {
            return this.MemberwiseClone() as Human;
        }
    }
}
