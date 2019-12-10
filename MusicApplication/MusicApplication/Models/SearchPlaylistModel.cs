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
    public class SearchPlaylistModel : BaseModel
    {
        public BindingList<Playlist> SearchResultsList { get; set; }

        public SearchPlaylistModel(Query queryManager)
        {
            SearchResultsList = new BindingList<Playlist>();
            QueryManager = queryManager;
        }

        public void GetItems(SearchQuery searchQuery)
        {
            if (searchQuery.EntityType != typeof(Playlist))
            {
                return;
            }

            SearchResultsList.Clear();
            
            var result = QueryManager.GetPlaylists(searchQuery.Text);

            if (result.Count() == 0)
                return;
            for(int i = 0; i < result.Count(); i++)
            {
                SearchResultsList.Add(result[i]);
            }
        }
    }
}
