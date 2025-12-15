using System;
using System.Collections.Generic;
using System.Text;

namespace Project__part_A_
{
    internal class Band
    {
        public string BandName { get; set; }
        public int MonthlyListening { get; set; }
        public List<Producer> Producers { get; set; }
        public List<Artist> Artists { get; set; }

        public Band(string name, List<Producer> producers)
        {
            BandName = name;
            Producers = producers;

            Artists = new List<Artist>();
        }
    }
}
