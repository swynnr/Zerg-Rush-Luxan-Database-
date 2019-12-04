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
    public partial class NameEntryForm : Form
    {
        public Playlist NewPlaylist { get; private set; }

        public NameEntryForm()
        {
            InitializeComponent();
            BindEvents();
            DialogResult = DialogResult.Cancel;
        }

        public NameEntryForm(string name) : this()
        {
            Text = name;
        }

        private void BindEvents()
        {
            _cancelButton.Click += CancelExit;
            _saveButton.Click += SaveExit;
            _textBox.TextChanged += TextBoxTextChanged;
        }

        private void TextBoxTextChanged(object sender, EventArgs e)
        {
            _saveButton.Enabled = !String.IsNullOrWhiteSpace(_textBox.Text);
        }

        private void SaveExit(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            NewPlaylist = new Playlist(DateTime.Now, _textBox.Text);
            Close();
        }

        private void CancelExit(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
