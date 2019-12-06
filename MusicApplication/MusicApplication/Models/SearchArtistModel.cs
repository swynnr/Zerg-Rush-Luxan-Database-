using MusicApplication.Data;
using QueryManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApplication
{
    public class SearchArtistModel : BaseModel
    {
        public BindingList<Artist> SearchResultsList { get; set; }

        public SearchArtistModel(Query queryManager)
        {
            SearchResultsList = new BindingList<Artist>();
            QueryManager = queryManager;
        }

        public void GetItems(SearchQuery searchQuery)
        {
            SearchResultsList.Clear();
            List<Artist> result;

            // TODO: populate with data
            if (searchQuery.EntityType != typeof(Artist))
            {
                return;
            }

            result = QueryManager.GetArtistsByName(searchQuery.Text);

            for (int i = 0; i < result.Count(); i++)
            {
                SearchResultsList.Add(result[i]);
            }

        }
    }
}