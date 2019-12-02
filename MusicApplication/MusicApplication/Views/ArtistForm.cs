using MusicApplication.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QueryManager;

namespace MusicApplication
{
    public partial class ArtistForm : BaseView
    {
        private AlbumModel _model;

        public ArtistForm(Query queryManager)
        {
            InitializeComponent();
            _model = new AlbumModel(queryManager);
            albumModelBindingSource.DataSource = _model;
            BindEvents();
        }

        public override void Open<T>(T item)
        {
            var artist = item as Artist;
            _model.SelectedArtist = artist;
        }

        private void BindEvents()
        {
            _albumGrid.CellDoubleClick += OpenAlbum;
        }
    }
}
