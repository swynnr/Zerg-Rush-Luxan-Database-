using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApplication
{
    public partial class SearchResultsForm : BaseView
    {
        public SearchResultsForm()
        {
            InitializeComponent();
        }

        public override void Open<T>(T item)
        {
            var searchTerm = item as SearchQuery;

        }
    }
}
