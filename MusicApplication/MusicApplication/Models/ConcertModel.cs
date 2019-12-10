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

        public void CreateConcert(Concert concert)
        {
            concert.ConcertId = QueryManager.CreateConcert(ref concert);
            ConcertList.Add(concert);
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
            if(SongList.Contains(song))
            {
                return;
            }
            SongList.Add(song);
        }

        private void PopulateConcertList()
        {
            ConcertList.Clear();
            List<Concert> temp = QueryManager.GetConcert("");
            for (int i = 0; i < temp.Count; i++)
            {
                ConcertList.Add(temp[i]);
            }
        }

        private void PopulateSongList(Concert concert)
        {

            SongList.Clear();
            List<Song> temp = QueryManager.GetSongsByConcertId(concert.ConcertId);
            for (int i = 0; i < temp.Count; i++)
            {
                SongList.Add(temp[i]);
            }

        }
    }
}
