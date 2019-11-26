using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace QueryManager
{
    class Query
    {
        private MySqlConnection connection = null;
        public Query(string host, string db, string username, string password)
        {
            string connStr = string.Format("Server={0}; database{1}; UID={2}; password={3}", host, db, username, password);
            connection = new MySqlConnection(connStr);
            connection.Open();
        }

        private MySqlDataReader GetReader(string query)
        {
            var cmd = new MySqlCommand(query, connection);
            return cmd.ExecuteReader();
        }

        public void CreatePlaylist(string name)
        {

        }

        public void CreateConcert(string name, string location, DateTime date)
        {

        }

        public void PlaylistAdd(int playlistId, int songId)
        {

        }

        public void ConcertAdd(int concertId, int songId)
        {

        }

        public void DeletePlaylist(int playlistId)
        {

        }

        public void DeleteConcert(int concertId)
        {

        }

        public List<Artist> GetArtists(string name)
        {
            List<Artist> result = null;
            var reader = GetReader("result");
            while (reader.Read())
            {
            }
            return result;
        }

        public List<Playlist> GetPlaylists(string name)
        {
            List<Playlist> result = null;
            var reader = GetReader("result");
            while (reader.Read())
            {
            }
            return result;
        }

        public List<Concert> GetConcert(string name)
        {
            List<Concert> result = null;
            var reader = GetReader("result");
            while (reader.Read())
            {
            }
            return result;
        }

        public List<Album> GetAlbums(string name)
        {
            List<Album> result = null;
            var reader = GetReader("result");
            while (reader.Read())
            {
            }
            return result;
        }

        public List<Song> GetSongs(string name)
        {
            List<Song> result = null;
            var reader = GetReader("result");
            while (reader.Read())
            {
            }
            return result;
        }
    }
}
