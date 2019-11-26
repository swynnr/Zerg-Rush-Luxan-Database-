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

        public Concert(int _concertId, string _concertName, string _location, DateTime _date)
        {
            ConcertId = _concertId;
            ConcertName = _concertName;
            Location = _location;
            Date = _date;
        }

        public Concert(int _concertId, string _concertName, string _location)
        {
            ConcertId = _concertId;
            ConcertName = _concertName;
            Location = _location;
            Date = DateTime.Now;
        }
    }
}
