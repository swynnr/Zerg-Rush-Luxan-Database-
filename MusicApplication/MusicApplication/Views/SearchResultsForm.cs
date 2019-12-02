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
    public partial class SearchResultsForm : BaseView
    {
        private SearchModel<Artist> _artistModel;
        private SearchModel<Album> _albumModel;
        private SearchModel<Song> _songModel;

        public SearchResultsForm()
        {
            InitializeComponent();
            _artistModel = new SearchModel<Artist>();
            _albumModel = new SearchModel<Album>();
            _songModel = new SearchModel<Song>();
            albumBindingList.DataSource = _albumModel.SearchResultsList;
            artistBindingList.DataSource = _artistModel.SearchResultsList;
            songBindingList.DataSource = _songModel.SearchResultsList;
        }

        public override void Open<T>(T item)
        {
            var searchTerm = item as SearchQuery;
            _albumModel.GetItems(searchTerm);
            // TODO: Switch DataGridView visibility based on the type of item search for

            if (searchTerm.EntityType == typeof(Artist))
            {
                _artistGrid.Visible = true;
                _albumGrid.Visible = false;
                _songGrid.Visible = false;
                return;
            }
            if (searchTerm.EntityType == typeof(Album))
            {
                _artistGrid.Visible = false;
                _albumGrid.Visible = true;
                _songGrid.Visible = false;
                return;
            }
            if (searchTerm.EntityType == typeof(Song))
            {
                _artistGrid.Visible = false;
                _albumGrid.Visible = false;
                _songGrid.Visible = true;
                return;
            }
        }
    }
}
