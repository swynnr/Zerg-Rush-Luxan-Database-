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
        public string EntityName { get; private set; }

        public NameEntryForm()
        {
            InitializeComponent();
            BindEvents();
        }

        public NameEntryForm(string name) : this()
        {
            Text = name;
        }

        private void BindEvents()
        {
            _cancelButton.Click += CancelExit;
            _saveButton.Click += SaveExit;
        }

        private void SaveExit(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelExit(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            EntityName = _textBox.Text;
        }
    }
}
