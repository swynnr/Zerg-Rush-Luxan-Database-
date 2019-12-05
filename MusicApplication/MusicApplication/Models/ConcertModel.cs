using MusicApplication.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueryManager;

namespace MusicApplication
{
    public class ConcertModel : BaseModel
    {
        public BindingList<Concert> ConcertList { get; set; }
        public BindingList<Song> SongList { get; set; }

        public ConcertModel(Query queryManager)
        {
            ConcertList = new BindingList<Concert>();
            SongList = new BindingList<Song>();
            QueryManager = queryManager;
            PopulateConcertList();
        }

        public void SelectConcert(Concert concert)
        {
            PopulateSongList(concert);
        }

        public bool CreateConcert(Concert concert)
        {
            var createdSuccessfully = QueryManager.CreateConcert(ref concert);
            if(createdSuccessfully)
            {
                ConcertList.Add(concert);
            }

            return createdSuccessfully;
        }

        public void DeletePlaylist(Concert concert)
        {
            QueryManager.DeleteConcert(concert);
            ConcertList.Remove(concert);
        }

        public void RemoveSongFromPlaylist(Concert concert, Song song)
        {
            QueryManager.ConcertRemoveSong(concert, song);
            SongList.Remove(song);
        }

        public void AddSongToPlaylist(Concert concert, Song song)
        {
            QueryManager.ConcertAddSong(concert, song);
            SongList.Add(song);
        }

        private void PopulateConcertList()
        {
            List<Concert> result;
            result = QueryManager.GetConcert("");

            for(int i = 0; i < result.Count(); i++)
            {
                ConcertList.Add(result[i]);
            }
            // TODO: Get songs from DB
            //ConcertList.Add(new Concert("Justin Beiber's World Tour", "The World"));
            //ConcertList.Add(new Concert("Sam's Western Fiesta", "Houston, TX"));
            //ConcertList.Add(new Concert("Cody Tang Gang", "Las Vegas, NV"));

            
        }

        private void PopulateSongList(Concert concert)
        {
            SongList.Clear();
            List<Song> temp = QueryManager.GetConcertSongs(concert.ConcertId);
            for (int i = 0; i < temp.Count; i++)
            {
                SongList.Add(temp[i]);
            }
        }
    }
}
