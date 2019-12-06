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
            List<Song> result;

            if (searchQuery.EntityType != typeof(Song))
            {
                return;
            }

            result = QueryManager.GetSongsByName(searchQuery.Text);
            
            for(int i = 0; i < result.Count(); i++)
            {
                SearchResultsList.Add(result[i]);
            }
        }
    }
}
