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

        public SongModel(Query queryManager)
        {
            Songs = new BindingList<Song>();
            QueryManager = queryManager;
        }

        private void UpdateSongList()
        {
            Songs.Clear();

        }
        
    }
}
