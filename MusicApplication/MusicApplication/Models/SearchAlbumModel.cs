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
            SearchResultsList.Clear();

            // TODO: populate with data
            if (searchQuery.EntityType != typeof(Album))
            {
                return;
            }
            SearchResultsList.Add(new Album(0, "The Bees", DateTime.Now));
            SearchResultsList.Add(new Album(100, "Blac", DateTime.Now));
            SearchResultsList.Add(new Album(200, "The happening", DateTime.Now));
            SearchResultsList.Add(new Album(303, "The Foo", DateTime.Now));
        }
    }
}
