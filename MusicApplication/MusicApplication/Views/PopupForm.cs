using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApplication.Views
{
    public partial class PopupForm : Form
    {
        public PopupForm(string diaglog)
        {
            _popupFormDialog.Text = diaglog;
            InitializeComponent();
        }

        private void popupButtonClose(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
