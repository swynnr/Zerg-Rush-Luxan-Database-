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
    public partial class ConcertCreationDialog : Form
    {
        public Concert NewConcert { get; private set; }

        public ConcertCreationDialog()
        {
            InitializeComponent();
            BindEvents();
            DialogResult = DialogResult.Cancel;
        }

        private void BindEvents()
        {
            _saveButton.Click += SavePressed;
            _cancelButton.Click += CancelPressed;
            _nameTextBox.TextChanged += CheckForEmptyText;
            _locationTextBox.TextChanged += CheckForEmptyText;
        }

        private void CheckForEmptyText(object sender, EventArgs e)
        {
            _saveButton.Enabled = !String.IsNullOrWhiteSpace(_nameTextBox.Text) &&
                                  !String.IsNullOrWhiteSpace(_locationTextBox.Text);
        }

        private void CancelPressed(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SavePressed(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            NewConcert = new Concert(_datePicker.Value, _nameTextBox.Text, _locationTextBox.Text);
            Close();
        }
    }
}
