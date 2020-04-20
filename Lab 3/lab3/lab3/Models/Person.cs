using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab3.Model
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string age { get; set; }
        public string email { get; set; }
        public string dob { get; set; }
        public string password { get; set; }
        public string desc { get; set; }
    }
}
