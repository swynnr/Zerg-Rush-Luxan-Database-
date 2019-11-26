using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MusicApplication.Data
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string AlbumName { get; set; }
        public DateTime ReleaseDate { get; set; }

        public Album(int _albumId, string _albumName, DateTime _releaseDate)
        {
            AlbumId = _albumId;
            AlbumName = _albumName;
            ReleaseDate = _releaseDate;
        }

    }
}
