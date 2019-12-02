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
    public partial class BaseView : UserControl
    {
        public MainForm Frame
        {
            get
            {
                return _mainForm;
            }
            set
            {
                _mainForm = value;
                Parent = value;
            }
        }

        public virtual void Open<T>(T item)
        {
            
        }

        private MainForm _mainForm;

        public BaseView()
        {
            InitializeComponent();
        }

        protected void OpenAlbum(object sender, DataGridViewCellEventArgs e)
        {
            var grid = sender as DataGridView;
            if (grid == null || e.RowIndex < 0)
            {
                return;
            }
            var selectedAlbum = grid.Rows[e.RowIndex].DataBoundItem as Album;
            if (selectedAlbum == null)
            {
                return;
            }

            Frame.DisplayObject(selectedAlbum);
        }

        protected void OpenArtist(object sender, DataGridViewCellEventArgs e)
        {
            var grid = sender as DataGridView;
            if(grid == null || e.RowIndex < 0)
            {
                return;
            }
            var selectedArtist = grid.Rows[e.RowIndex].DataBoundItem as Artist;
            if (selectedArtist == null)
            {
                return;
            }

            Frame.DisplayObject(selectedArtist);
        }
    }
}
