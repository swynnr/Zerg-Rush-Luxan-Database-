using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApplication.Data
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public string ArtistName { get; set; }

        public Artist(int _artistId, string _artistName)
        {
            ArtistId = _artistId;
            ArtistName = _artistName;
         }
    }
}
