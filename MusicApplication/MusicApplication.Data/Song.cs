using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApplication.Data
{
    public class Song
    {
        public int SongId { get; set; }
        public string SongName { get; set; }
        public TimeSpan Length { get; set; }
    }
}
