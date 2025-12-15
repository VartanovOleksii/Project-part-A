using System;
using System.Collections.Generic;
using System.Text;

namespace Project__part_A_
{
    internal interface IMediaContent
    {
        public void Play();
        public void Stop();
        public List<string> GetMetadata();
    }
}
