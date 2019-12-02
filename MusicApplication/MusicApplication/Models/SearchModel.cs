using MusicApplication.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApplication
{
    public class SearchModel<T>
    {
        public BindingList<T> SearchResultsList { get; set; }

        public SearchModel()
        {
            SearchResultsList = new BindingList<T>();
        }

        public void GetItems(SearchQuery searchQuery)
        {
            SearchResultsList.Clear();

            // TODO: populate with data
            if(typeof(T) == typeof(Artist))
            {

                return;
            }
            if(typeof(T) == typeof(Album))
            {

                return;
            }
            if(typeof(T) == typeof(Song))
            {

                return;
            }
        }
    }
}
