using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicApplication.Data;
using QueryManager;

namespace MusicApplication
{
    public partial class PopupForm : Form
    {
        public PopupForm(string diaglog)
        {
           
            InitializeComponent();
            _popupFormDialog.Text = diaglog;

        }

        private void popupButtonClose(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
