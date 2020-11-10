using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
    {

        //Veri tabanındaki kolonların karşılığı olarak tutarız

        //field
        public string FirstName;

        //property (Özellikler property olur)
        public int Id { get; set; }


        //encapsulation
        private string _name;
        public string Name {
            get{ return "Mr." + _name; } 
            set { _name = value; } 
        }


    }
}
