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
    public partial class ConcertForm : BaseView
    {
        private ConcertModel _model;
        private Query _queryManager;

        private Concert SelectedConcert
        {
            get
            {
                if (_concertGrid.SelectedRows.Count <= 0)
                {
                    return null;
                }
               return _concertGrid.SelectedRows[0].DataBoundItem as Concert;
            }
        }

        private Song SelectedSong
        {
            get
            {
                if(_songGrid.SelectedRows.Count <= 0)
                {
                    return null;
                }
                return _songGrid.SelectedRows[0].DataBoundItem as Song;
            }
        }

        public ConcertForm(Query queryManager)
        {
            InitializeComponent();
            _queryManager = queryManager;
            _model = new ConcertModel(queryManager);
            concertModelBindingSource.DataSource = _model;
            BindEvents();
        }

        private void BindEvents()
        {
            _concertGrid.SelectionChanged += ConcertGridSelectionChanged;
            _newButton.Click += CreateNewConcert;
            _deletePlaylistButton.Click += DeleteConcert;
            _deleteSongButton.Click += DeleteSong;
            _addButton.Click += AddNewSong;
        }

        private void AddNewSong(object sender, EventArgs e)
        {
            using(var songSearchForm = new SongSearchForm(_queryManager))
            {
                songSearchForm.Grid.CellDoubleClick += SongSearchFormClick;
                songSearchForm.ShowDialog(this);
            }
        }

        private void SongSearchFormClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = sender as DataGridView;
            var row = grid.Rows[e.RowIndex];
            var song = row.DataBoundItem as Song;
            if (SelectedConcert == null || song == null)
            {
                return;
            }
            _model.AddSongToPlaylist(SelectedConcert, song);
            TimeSpan runtime = new TimeSpan(0, 0, 0);

            for (int i = 0; i < _model.SongList.Count; i++)
                runtime = runtime + _model.SongList[i].Length;


            runtimeVariable.Text = runtime.ToString();
        }

        private void DeleteSong(object sender, EventArgs e)
        {
            if (SelectedConcert == null || SelectedSong == null)
            {
                return;
            }
            _model.RemoveSongFromPlaylist(SelectedConcert, SelectedSong);
        }

        private void DeleteConcert(object sender, EventArgs e)
        {
            if(SelectedConcert == null)
            {
                return;
            }
            _model.DeletePlaylist(SelectedConcert);
        }

        private void CreateNewConcert(object sender, EventArgs e)
        {
            Concert newConcert = null;
            using (var concertDialog = new ConcertCreationDialog())
            {
                var dialogResult = concertDialog.ShowDialog(this);
                if(dialogResult == DialogResult.Cancel)
                {
                    return;
                }
                newConcert = concertDialog.NewConcert;
            }

            _model.CreateConcert(newConcert);
        }

        private void ConcertGridSelectionChanged(object sender, EventArgs e)
        {
            if(SelectedConcert == null)
            {
                return;
            }
            _model.SelectConcert(SelectedConcert);
            
            TimeSpan runtime = new TimeSpan(0, 0, 0);

            for (int i = 0; i < _model.SongList.Count; i++)
                runtime = runtime + _model.SongList[i].Length;


            runtimeVariable.Text = runtime.ToString();
        }
    }
}
