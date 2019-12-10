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
        public BindingList<Artist> FeaturedArtists { get; set; }

        public ConcertModel(Query queryManager)
        {
            ConcertList = new BindingList<Concert>();
            SongList = new BindingList<Song>();
            FeaturedArtists = new BindingList<Artist>();
            QueryManager = queryManager;
            PopulateConcertList();
        }

        public void SelectConcert(Concert concert)
        {
            PopulateSongList(concert);
            PopulateFeaturedArtists(concert);
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
            PopulateFeaturedArtists(concert);
        }

        public void AddSongToPlaylist(Concert concert, Song song)
        {
            QueryManager.ConcertAddSong(concert, song);
            if(SongList.Contains(song))
            {
                return;
            }
            SongList.Add(song);
            PopulateFeaturedArtists(concert);
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
            var temp = QueryManager.GetSongsByConcertId(concert.ConcertId);
            for (int i = 0; i < temp.Count; i++)
            {
                SongList.Add(temp[i]);
            }
        }

        private void PopulateFeaturedArtists(Concert concert)
        {
            FeaturedArtists.Clear();
            foreach(var song in SongList)
            {
                foreach (var artist in song.Artists)
                {
                    if (FeaturedArtists.Contains(artist))
                    {
                        continue;
                    }
                    FeaturedArtists.Add(artist);
                }
            }
        }
    }
}
