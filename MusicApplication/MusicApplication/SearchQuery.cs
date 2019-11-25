using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApplication
{
    public class SearchQuery
    {
        public string Text;
        public Type EntityType;

        public SearchQuery(string text, Type entityType)
        {
            Text = text;
            EntityType = entityType;
        }
    }
}
