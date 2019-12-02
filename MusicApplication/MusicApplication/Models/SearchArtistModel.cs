using MusicApplication.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApplication
{
    public class SearchArtistModel
    {
        public BindingList<Artist> SearchResultsList { get; set; }

        public SearchArtistModel()
        {
            SearchResultsList = new BindingList<Artist>();
        }

        public void GetItems(SearchQuery searchQuery)
        {
            SearchResultsList.Clear();

            // TODO: populate with data
            if (searchQuery.EntityType != typeof(Artist))
            {
                return;
            }
            SearchResultsList.Add(new Artist(0, "Jonny Dep"));
            SearchResultsList.Add(new Artist(1, "Shrek"));
            SearchResultsList.Add(new Artist(2, "Maroon 5"));
            SearchResultsList.Add(new Artist(3, "Alice"));
            SearchResultsList.Add(new Artist(4, "Cody Tang"));
        }
    }
}
