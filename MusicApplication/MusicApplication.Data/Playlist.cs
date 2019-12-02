using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApplication.Data
{
    public class Playlist
    {
        public int PlaylistId { get; set; }
        public string PlaylistName { get; set; }
        public DateTime Date { get; set; }

        public Playlist(int playlistId, string playlistName, DateTime date)
        {
            PlaylistId = playlistId;
            PlaylistName = playlistName;
            Date = date;
        }

        public Playlist(int playlistId, string playlistName)
        {
            PlaylistId = playlistId;
            PlaylistName = playlistName;
            Date = DateTime.Now;
        }

        public override string ToString()
        {
            return PlaylistName;
        }
    }
}
