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
    public partial class AlbumForm : BaseView
    {
        public AlbumForm()
        {
            InitializeComponent();
        }

        public override void Open<T>(T item)
        {
            var album = item as Album;

        }
    }
}
