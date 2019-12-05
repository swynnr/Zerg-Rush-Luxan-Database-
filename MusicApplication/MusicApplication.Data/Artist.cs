﻿using System;
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

        public Artist(int artistId, string artistName)
        {
            ArtistId = artistId;
            ArtistName = artistName;
        }

        public override string ToString()
        {
            return ArtistName;
        }
    }
}
