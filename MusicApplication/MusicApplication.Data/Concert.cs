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

        public Concert(int concertId, string concertName, string location, DateTime date)
        {
            ConcertId = concertId;
            ConcertName = concertName;
            Location = location;
            Date = date;
        }

        public Concert(int concertId, string concertName, string location)
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
