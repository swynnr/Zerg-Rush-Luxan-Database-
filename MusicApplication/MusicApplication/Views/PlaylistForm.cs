using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicApplication.Data;
using QueryManager;

namespace MusicApplication
{
    public partial class PlaylistForm : BaseView
    {
        private PlaylistModel _model;

        public PlaylistForm(Query queryManager)
        {
            InitializeComponent();
            _model = new PlaylistModel(queryManager);
            playlistModelBindingSource.DataSource = _model;
            BindEvents();
        }

        private void BindEvents()
        {
            _playlistGrid.SelectionChanged += PlaylistGridSelectionChanged;
            _newButton.Click += CreateNewPlaylist;
            _deletePlaylistButton.Click += DeletePlaylist;
        }

        private void DeletePlaylist(object sender, EventArgs e)
        {
            if(_playlistGrid.SelectedRows.Count <= 0)
            {
                return;
            }
            var rowToDelete = _playlistGrid.SelectedRows[0];
            _model.DeletePlaylist(rowToDelete.DataBoundItem as Playlist);
        }

        private void CreateNewPlaylist(object sender, EventArgs e)
        {
            string name = "";
            using (var nameEntryForm = new NameEntryForm())
            {
                var dialogResult = nameEntryForm.ShowDialog(this);
                if(dialogResult == DialogResult.Cancel)
                {
                    return;
                }
                name = nameEntryForm.EntityName;
            }

            if(String.IsNullOrWhiteSpace(name))
            {
                return;
            }

            _model.CreatePlaylist(name);
        }

        private void PlaylistGridSelectionChanged(object sender, EventArgs e)
        {
            if(_playlistGrid.SelectedRows.Count <= 0)
            {
                return;
            }
            var selectedRow = _playlistGrid.SelectedRows[0];
            _model.SelectPlaylist(selectedRow.DataBoundItem as Playlist);
        }
    }
}
