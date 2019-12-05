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
    public partial class SongSearchForm : Form
    {
        private Query _queryManager;
        private SearchSongModel _model;

        public SongSearchForm(Query queryManager)
        {
            InitializeComponent();
            _queryManager = queryManager;
            _model = new SearchSongModel(queryManager);
            searchSongModelBindingSource.DataSource = _model;
            BindEvents();
        }

        private void BindEvents()
        {
            _searchButton.Click += SearchButtonClick;
        }

        private void SearchButtonClick(object sender, EventArgs e)
        {
            var searchQuery = new SearchQuery(_searchText.Text, typeof(Song));
            _model.GetItems(searchQuery);
        }
    }
}
