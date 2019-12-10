using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApplication.Data
{
    public class Song : IEquatable<Song>
    {
        public int SongId { get; set; }
        public string SongName { get; set; }
        public TimeSpan Length { get; set; }
        
        public Song(int songId, string songName, TimeSpan length)
        {
            SongId = songId;
            SongName = songName;
            Length = length;
        }

        public override string ToString()
        {
            return SongName;
        }

        bool IEquatable<Song>.Equals(Song other)
        {
            return SongId.Equals(other.SongId);
        }
    }
}
