using MusicApplication.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApplication
{
    public class SongModel
    {
        public BindingList<Song> Songs { get; set; }
        private Artist _selectedAlbum;

        public Artist SelectedArtist
        {
            get
            {
                return _selectedAlbum;
            }
            set
            {
                _selectedAlbum = value;
                UpdateSongList();
            }
        }

        public SongModel()
        {
            Songs = new BindingList<Song>();
        }

        private void UpdateSongList()
        {
            // Call to query manager to get list for _selectedArtist
        }
    }
}
