using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApplication.Data
{
    public class Playlist : IEquatable<Playlist>
    {
        public int PlaylistId { get; set; }
        public string PlaylistName { get; set; }
        public DateTime Date { get; set; }

        public Playlist(DateTime date, string playlistName = "", int playlistId = -1)
        {
            PlaylistId = playlistId;
            PlaylistName = playlistName;
            Date = date;
        }

        public Playlist(string playlistName = "", int playlistId = -1)
        {
            PlaylistId = playlistId;
            PlaylistName = playlistName;
            Date = DateTime.Now;
        }

        public override string ToString()
        {
            return PlaylistName;
        }

        bool IEquatable<Playlist>.Equals(Playlist other)
        {
            return PlaylistId.Equals(other.PlaylistId);
        }
    }
}
