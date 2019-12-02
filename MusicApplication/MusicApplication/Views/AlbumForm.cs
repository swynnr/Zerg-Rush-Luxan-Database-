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
    public partial class AlbumForm : BaseView
    {
        private SongModel _model;

        public AlbumForm(Query queryManager)
        {
            InitializeComponent();
            _model = new SongModel(queryManager);
            songModelBindingSource.DataSource = _model;
        }

        public override void Open<T>(T item)
        {
            var album = item as Album;
            _model.SelectedAlbum = album;
        }
    }
}
