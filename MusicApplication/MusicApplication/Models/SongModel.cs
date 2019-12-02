using MusicApplication.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApplication
{
    public class SongModel : BaseModel
    {
        public BindingList<Song> Songs { get; set; }
        private Album _selectedAlbum;

        public Album SelectedAlbum
        {
            get
            {
                return _selectedAlbum;
            }
            set
            {
                _selectedAlbum = value;
                UpdateSongList();
                OnPropertyChanged("Album");
            }
        }

        public SongModel()
        {
            Songs = new BindingList<Song>();
        }

        private void UpdateSongList()
        {
            Songs.Clear();
            Songs.Add(new Song(2, "Sadness", TimeSpan.FromMinutes(3)));
            Songs.Add(new Song(6, "Happiness", TimeSpan.FromMinutes(4.5)));
            Songs.Add(new Song(3344, "Joy", TimeSpan.FromMinutes(2.3)));
            Songs.Add(new Song(3, "Angst", TimeSpan.FromMinutes(.77)));
        }
        
    }
}
