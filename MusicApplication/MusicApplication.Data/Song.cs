using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApplication.Data
{
    public class Song
    {
        public int SongId { get; set; }
        public string SongName { get; set; }
        public TimeSpan Length { get; set; }

        public Song(int _songId, string _songName, TimeSpan _length)
        {
            SongId = _songId;
            SongName = _songName;
            Length = _length;
        }
    }
}
