using System;
using System.Collections.Generic;
using System.Text;

namespace Project__part_A_
{
    internal class Artist: IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public string Instrument { get; set; }
        public bool IsActive { get; set; }
        public int FanCount { get; set; }

        public Artist(string name, int age, double salary, string instrument)
        {
            Name = name;
            Age = age;
            Salary = salary;
            Instrument = instrument;
        }
    }
}
