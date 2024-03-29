﻿using System;
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
        private Query _queryManager;

        private Playlist SelectedPlaylist
        {
            get
            {
                if (_playlistGrid.SelectedRows.Count <= 0)
                {
                    return null;
                }
               return _playlistGrid.SelectedRows[0].DataBoundItem as Playlist;
            }
            set
            {
                for(int i = 0; i < _playlistGrid.Rows.Count; i++)
                {
                    _playlistGrid.Rows[i].Selected = false;
                    var playlist = _playlistGrid.Rows[i].DataBoundItem as Playlist;
                    if (playlist == null || !playlist.Equals(value))
                    {
                        continue;
                    }
                    _playlistGrid.Rows[i].Selected = true;
                }
                _model.SelectPlaylist(value);
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

        public PlaylistForm(Query queryManager)
        {
            InitializeComponent();
            _queryManager = queryManager;
            _model = new PlaylistModel(queryManager);
            playlistModelBindingSource.DataSource = _model;
            BindEvents();
        }

        public override void Open<T>(T item)
        {
            var playlist = item as Playlist;
            SelectedPlaylist = playlist;
        }

        private void BindEvents()
        {
            _playlistGrid.SelectionChanged += PlaylistGridSelectionChanged;
            _newButton.Click += CreateNewPlaylist;
            _deletePlaylistButton.Click += DeletePlaylist;
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
            
            if (SelectedPlaylist == null || song == null)
            {
                return;
            }

            _model.PopulateSongList(SelectedPlaylist);
           
            if (_model.SongList.Contains(song))
            {
                return;
            }

            _model.AddSongToPlaylist(SelectedPlaylist, song);
            TimeSpan runtime = new TimeSpan(0, 0, 0);

            for (int i = 0; i < _model.SongList.Count; i++)
            {
                runtime = runtime + _model.SongList[i].Length;
            }
            
            runtimeVariable.Text = runtime.ToString();
        }

        private void DeleteSong(object sender, EventArgs e)
        {
            if (SelectedPlaylist == null || SelectedSong == null)
            {
                return;
            }
            _model.RemoveSongFromPlaylist(SelectedPlaylist, SelectedSong);
            TimeSpan runtime = new TimeSpan(0, 0, 0);

            for (int i = 0; i < _model.SongList.Count; i++)
            {
                runtime = runtime + _model.SongList[i].Length;
            }

            runtimeVariable.Text = runtime.ToString();
        }

        private void DeletePlaylist(object sender, EventArgs e)
        {
            if(SelectedPlaylist == null)
            {
                return;
            }
            _model.DeletePlaylist(SelectedPlaylist);
        }

        private void CreateNewPlaylist(object sender, EventArgs e)
        {
            Playlist playlist = null;
            using (var nameEntryForm = new NameEntryForm("Create a New Playlist"))
            {
                var dialogResult = nameEntryForm.ShowDialog(this);
                if(dialogResult == DialogResult.Cancel)
                {
                    return;
                }
                playlist = nameEntryForm.NewPlaylist;
            }

            _model.CreatePlaylist(playlist);
        }

        private void PlaylistGridSelectionChanged(object sender, EventArgs e)
        {
            if(SelectedPlaylist == null)
            {
                return;
            }
            _model.SelectPlaylist(SelectedPlaylist);

            TimeSpan runtime = new TimeSpan(0, 0, 0);

            for (int i = 0; i < _model.SongList.Count; i++)
            {
                runtime = runtime + _model.SongList[i].Length;
            }
            
            runtimeVariable.Text = runtime.ToString();
        }
    }
}
