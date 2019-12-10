using MusicApplication.Data;
using QueryManager;
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
    public partial class SearchResultsForm : BaseView
    {
        private SearchArtistModel _artistModel;
        private SearchAlbumModel _albumModel;
        private SearchSongModel _songModel;
        private SearchPlaylistModel _playlistModel;

        public SearchResultsForm(Query queryManager)
        {
            InitializeComponent();
            _artistModel = new SearchArtistModel(queryManager);
            _albumModel = new SearchAlbumModel(queryManager);
            _songModel = new SearchSongModel(queryManager);
            _playlistModel = new SearchPlaylistModel(queryManager);
            albumSearchBindingSource.DataSource = _albumModel.SearchResultsList;
            artistSearchBindingSource.DataSource = _artistModel.SearchResultsList;
            songSearchBindingSource.DataSource = _songModel.SearchResultsList;
            playlistListBindingSource.DataSource = _playlistModel.SearchResultsList;
            BindEvents();
        }

        public override void Open<T>(T item)
        {
            var searchTerm = item as SearchQuery;

            if (searchTerm.EntityType == typeof(Artist))
            {
                _artistModel.GetItems(searchTerm);
                _artistGrid.Visible = true;
                _albumGrid.Visible = false;
                _songGrid.Visible = false;
                _playlistGrid.Visible = false;
                return;
            }
            if (searchTerm.EntityType == typeof(Album))
            {
                _albumModel.GetItems(searchTerm);
                _artistGrid.Visible = false;
                _albumGrid.Visible = true;
                _songGrid.Visible = false;
                _playlistGrid.Visible = false;
                return;
            }
            if (searchTerm.EntityType == typeof(Song))
            {
                _songModel.GetItems(searchTerm);
                _artistGrid.Visible = false;
                _albumGrid.Visible = false;
                _songGrid.Visible = true;
                _playlistGrid.Visible = false;
                return;
            }
            if(searchTerm.EntityType == typeof(Playlist))
            {
                _playlistModel.GetItems(searchTerm);
                _artistGrid.Visible = false;
                _albumGrid.Visible = false;
                _songGrid.Visible = false;
                _playlistGrid.Visible = true;
            }
        }

        private void BindEvents()
        {
            _artistGrid.CellDoubleClick += OpenArtist;
            _albumGrid.CellDoubleClick += OpenAlbum;
            _playlistGrid.CellDoubleClick += OpenPlaylist;
        }

        private void OpenPlaylist(object sender, DataGridViewCellEventArgs e)
        {
            var grid = sender as DataGridView;
            if (grid == null || e.RowIndex < 0)
            {
                return;
            }
            var selectedPlaylist = grid.Rows[e.RowIndex].DataBoundItem as Playlist;
            if (selectedPlaylist == null)
            {
                return;
            }

            Frame.DisplayObject(selectedPlaylist);
        }
    }
}
