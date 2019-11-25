using MusicApplication.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApplication.Models
{
    public class AlbumModel
    {
        public BindingList<Album> Albums;
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
            }
        }

        public AlbumModel()
        {
            Albums = new BindingList<Album>();
        }

        private void UpdateAlbumList()
        {
            // Call to query manager to get list for _selectedArtist
        }
    }
}
