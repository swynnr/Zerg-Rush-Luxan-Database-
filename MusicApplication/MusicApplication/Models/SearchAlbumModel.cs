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
    public class SearchAlbumModel : BaseModel
    {
        public BindingList<Album> SearchResultsList { get; set; }

        public SearchAlbumModel(Query queryManager)
        {
            SearchResultsList = new BindingList<Album>();
            QueryManager = queryManager;
        }

        public void GetItems(SearchQuery searchQuery)
        {
            if (searchQuery.EntityType != typeof(Album))
            {
                return;
            }

            SearchResultsList.Clear();

            var result = QueryManager.GetAlbumsByName(searchQuery.Text);
            
            for (int i = 0; i < result.Count(); i++)
            {
                SearchResultsList.Add(result[i]);
            }
        }
    }
}
