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

        public Concert(DateTime date, string concertName = "", string location = "", int concertId = -1)
        {
            ConcertId = concertId;
            ConcertName = concertName;
            Location = location;
            Date = date;
        }

        public Concert(string concertName = "", string location = "", int concertId = -1)
        {
            ConcertId = concertId;
            ConcertName = concertName;
            Location = location;
            Date = DateTime.Now;
        }

        public override string ToString()
        {
            return ConcertName;
        }
    }
}
