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

        public bool CreatePlaylist(Playlist playlist)
        {
            var createdSuccessfully = QueryManager.CreatePlaylist(ref playlist);
            if (createdSuccessfully)
            {
                PlaylistList.Add(playlist);
            }

            return createdSuccessfully;
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
            // TODO: Get songs from DB
            PlaylistList.Add(new Playlist("Matt's Epic Playlist"));
            PlaylistList.Add(new Playlist("Bangers"));
            PlaylistList.Add(new Playlist("Happy Songs"));
            PlaylistList.Add(new Playlist("Road Trip"));
            PlaylistList.Add(new Playlist("Sad music"));
        }

        private void PopulateSongList(Playlist playlist)
        {
            //SongList.Clear();
            // TODO: Get songs based on SelectedPlaylist
          
        }
    }
}
