using System;
using System.Collections.Generic;
using System.Text;

namespace Project__part_A_
{
    public class Producer: IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public int YearsOfExperience { get; set; }
        public string Specialization { get; set; }

        public Producer()
        {
            throw new NotImplementedException();
        }

        public Producer(string name, int age, double salary, string specialization)
        {
            throw new NotImplementedException();

            Name = name;
            Age = age;
            Salary = salary;
            Specialization = specialization;
        }
    }
}
