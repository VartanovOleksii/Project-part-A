using System;
using System.Collections.Generic;
using System.Text;

namespace Project__part_A_
{
    public class Song: IMediaContent
    {
        //Public properties
        public string SongName { get; set; }
        public int TotalPlays { get; set; }

        public Band Band { get; set; }
        public Genre Genre { get; set; }

        //Public methods
        public void Play()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public List<string> GetMetadata()
        {
            throw new NotImplementedException();
        }


        //Constructors
        public Song()
        {
            throw new NotImplementedException();
        }

        public Song(string name, Band band, Genre genre)
        {
            throw new NotImplementedException();

            SongName = name;
            Band = band;
            Genre = genre;
        }
    }
}
