using System;
using System.Collections.Generic;
using System.Text;

namespace Project__part_A_
{
    internal class RecordLabel
    {
        public string RecordLabelName { get; set; }
        public List<Band> Bands { get; set; }

        public bool SignBand(Band band)
        {
            throw new NotImplementedException();
        }

        public double Revenue(Band band, double rate)
        {
            throw new NotImplementedException();
        }

        public RecordLabel(string name, List<Band> bands)
        {
            throw new NotImplementedException();

            RecordLabelName = name;
            Bands = bands;
        }
    }
}
