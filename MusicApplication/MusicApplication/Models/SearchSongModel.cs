using MusicApplication.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueryManager;

namespace MusicApplication
{
    public class SearchSongModel : BaseModel
    {
        public BindingList<Song> SearchResultsList { get; set; }

        public SearchSongModel(Query queryManager)
        {
            SearchResultsList = new BindingList<Song>();
            QueryManager = queryManager;
        }

        public void GetItems(SearchQuery searchQuery)
        {
            SearchResultsList.Clear();
            if (searchQuery.EntityType != typeof(Song))
            {
                return;
            }
            SearchResultsList.Add(new Song(2, "Sadness", TimeSpan.FromMinutes(3)));
            SearchResultsList.Add(new Song(6, "Happiness", TimeSpan.FromMinutes(4.5)));
            SearchResultsList.Add(new Song(3344, "Joy", TimeSpan.FromMinutes(2.3)));
            SearchResultsList.Add(new Song(3, "Angst", TimeSpan.FromMinutes(.77)));
        }
    }
}
