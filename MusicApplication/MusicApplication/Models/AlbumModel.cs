using MusicApplication.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public AlbumModel()
        {
            Albums = new BindingList<Album>();
        }

        private void UpdateAlbumList()
        {
            Albums.Clear();
            Albums.Add(new Album(0, "The Bees", DateTime.Now));
            Albums.Add(new Album(100, "Blac", DateTime.Now));
            Albums.Add(new Album(200, "The happening", DateTime.Now));
            Albums.Add(new Album(303, "The Foo", DateTime.Now));
        }
    }
}
