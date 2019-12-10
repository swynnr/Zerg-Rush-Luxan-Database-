using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MusicApplication.Data
{
    public class Album : IEquatable<Album>
    {
        public int AlbumId { get; set; }
        public string AlbumName { get; set; }
        public DateTime ReleaseDate { get; set; }

        public Album(int albumId, string albumName, DateTime releaseDate)
        {
            AlbumId = albumId;
            AlbumName = albumName;
            ReleaseDate = releaseDate;
        }

        public override string ToString()
        {
            return AlbumName;
        }

        bool IEquatable<Album>.Equals(Album other)
        {
            return AlbumId.Equals(other.AlbumId);
        }
    }
}
