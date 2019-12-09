using MusicApplication.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueryManager;

namespace MusicApplication
{
    public class PlaylistModel : BaseModel
    {
        public BindingList<Playlist> PlaylistList { get; set; }
        public BindingList<Song> SongList { get; set; }

        public PlaylistModel(Query queryManager)
        {
            PlaylistList = new BindingList<Playlist>();
            SongList = new BindingList<Song>();
            QueryManager = queryManager;
            PopulatePlaylistList();
        }

        public void SelectPlaylist(Playlist playlist)
        {
            PopulateSongList(playlist);
        }

        public void CreatePlaylist(Playlist playlist)
        {
            playlist.PlaylistId = QueryManager.CreatePlaylist(ref playlist);
            PlaylistList.Add(playlist);
        }

        public void DeletePlaylist(Playlist playlist)
        {
            QueryManager.DeletePlaylist(playlist);
            PlaylistList.Remove(playlist);
        }

        public void RemoveSongFromPlaylist(Playlist playlist, Song song)
        {
            QueryManager.PlaylistRemoveSong(playlist, song);
            SongList.Remove(song);
        }

        public void AddSongToPlaylist(Playlist selectedPlaylist, Song song)
        {

                QueryManager.PlaylistAddSong(selectedPlaylist, song);
                SongList.Add(song);    
        }

        private void PopulatePlaylistList()
        {
            PlaylistList.Clear();
            List<Playlist> temp = QueryManager.GetPlaylists("");
            for (int i = 0; i < temp.Count; i++)
            {
                PlaylistList.Add(temp[i]);
            }
            
        }

        public void PopulateSongList(Playlist playlist)
        {

            SongList.Clear();
            List<Song> temp = QueryManager.GetSongsByPlaylistId(playlist.PlaylistId);
            for (int i = 0; i < temp.Count; i++)
            {
                SongList.Add(temp[i]);
            }

        }
    }
}
