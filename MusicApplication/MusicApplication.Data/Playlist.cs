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

        public Playlist(int _playlistId, string _playlistName, DateTime _date)
        {
            PlaylistId = _playlistId;
            PlaylistName = _playlistName;
            Date = _date;
        }

        public Playlist(int _playlistId, string _playlistName)
        {
            PlaylistId = _playlistId;
            PlaylistName = _playlistName;
            Date = DateTime.Now;
        }
    }
}
