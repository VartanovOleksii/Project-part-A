using System;
using System.Collections.Generic;
using System.Text;

namespace Project__part_A_
{
    internal class Song
    {
        public string SongName { get; set; }
        public int TotalPlays { get; set; }

        public Band Band { get; set; }
        public Genre Genre { get; set; }

        public Song(string name, Band band, Genre genre)
        {
            SongName = name;
            Band = band;
            Genre = genre;
        }
    }
}
