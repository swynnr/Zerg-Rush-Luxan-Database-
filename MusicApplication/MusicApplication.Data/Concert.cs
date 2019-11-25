using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApplication.Data
{
    public class Concert
    {
        public int ConcertId { get; set; }
        public string ConcertName { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
    }
}
