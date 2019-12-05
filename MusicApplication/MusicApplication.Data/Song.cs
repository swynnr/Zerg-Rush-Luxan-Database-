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

        public DateTime PublishDate { get; set; }

        private int AlbumID { get; set; }

        public TimeSpan Length { get; set; }

        

        public Song(int songId, string songName, DateTime publishDate, int albumID, TimeSpan length)
        {
            SongId = songId;
            SongName = songName;
            Length = length;
            PublishDate = publishDate;
            AlbumID = albumID;
        }

        public override string ToString()
        {
            return SongName;
        }
    }
}
