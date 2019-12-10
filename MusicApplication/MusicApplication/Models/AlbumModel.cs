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
    public class AlbumModel : BaseModel
    {
        public BindingList<Album> Albums { get; set; }
        private Artist _selectedArtist;

        public Artist SelectedArtist
        {
            get
            {
                return _selectedArtist;
            }
            set
            {
                _selectedArtist = value;
                UpdateAlbumList();
                OnPropertyChanged("Artist");
            }
        }

        public AlbumModel(Query queryManager)
        {
            Albums = new BindingList<Album>();
            QueryManager = queryManager;
        }

        private void UpdateAlbumList()
        {
            Albums.Clear();
            
        }
    }
}
