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

namespace MusicApplication
{
    public partial class ArtistForm : BaseView
    {
        private AlbumModel _model;

        public ArtistForm()
        {
            InitializeComponent();
            _model = new AlbumModel();
        }

        public override void Open<T>(T item)
        {
            var artist = item as Artist;

        }
    }
}
