using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_
{
    public class User : Monitor
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public User(string name, int age, string[] racion, string[] fisical,
            string[] privichka) : base(racion, fisical,
                privichka)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
