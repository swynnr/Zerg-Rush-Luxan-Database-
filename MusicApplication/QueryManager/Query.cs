using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using MusicApplication.Data;

namespace QueryManager
{
    public class Query
    {
        private MySqlConnection connection = null;
        public Query(string host, string db, string username, string password)
        {
            string connStr = string.Format("Server={0}; database={1}; UID={2}; password={3}", host, db, username, password);
            connection = new MySqlConnection(connStr);
            connection.Open();
        }

        private MySqlDataReader GetReader(string query)
        {
            var cmd = new MySqlCommand(query, connection);
            return cmd.ExecuteReader();
        }

        private void ExecuteNonQuery(string command)
        {
            var cmd = new MySqlCommand(command, connection);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// This method should take in a playlist object, create the playlist in the DB using the other
        /// parameters, then fill the playlist object with the proper id
        /// </summary>
        /// <param name="playlist"></param>
        /// <returns>Whether the playlist was created or not</returns>
        public bool CreatePlaylist(ref Playlist playlist)
        {
            string cmd = "temp";
            ExecuteNonQuery(cmd);

            return true;
        }

        /// <summary>
        /// This method should take in a concert, create the concert in the DB using the other
        /// parameters, then fill the concert object with the proper id
        /// </summary>
        /// <param name="concert"></param>
        /// <returns>Whether the concert was created or not</returns>
        public bool CreateConcert(ref Concert concert)
        {
            string cmd = "temp";
            ExecuteNonQuery(cmd);

            return true;
        }

        public void PlaylistAddSong(Playlist playlistId, Song songId)
        {
            string cmd = "temp";
            ExecuteNonQuery(cmd);
        }

        public void ConcertAddSong(Concert concert, Song song)
        {
            string cmd = "temp";
            ExecuteNonQuery(cmd);
        }

        public void PlaylistRemoveSong(Playlist playlist, Song song)
        {
            string cmd = "temp";
            ExecuteNonQuery(cmd);
        }

        public void ConcertRemoveSong(Concert playlist, Song song)
        {
            string cmd = "temp";
            ExecuteNonQuery(cmd);
        }

        public void DeletePlaylist(Playlist playlist)
        {
            string cmd = "temp";
            ExecuteNonQuery(cmd);
        }

        public void DeleteConcert(Concert concert)
        {
            string cmd = "temp";
            ExecuteNonQuery(cmd);
        }

        public List<Artist> GetArtistsByName(string name)
        {
            List<Artist> result = new List<Artist>();
            var reader = GetReader(@"SELECT ArtistID, artistName 
                                     FROM Artists WHERE artistName LIKE '%" + name + "%'");
            while (reader.Read())
            {
                Artist entry = new Artist((int)reader[0], (string)reader[1]);
                result.Add(entry);
            }
            return result;
        }

        public List<Artist> GetArtistsBySongId(int id)
        {
            List<Artist> result = new List<Artist>();
            var reader = GetReader("result");
            while (reader.Read())
            {
                Artist entry = new Artist((int)reader[0], (string)reader[1]);
                result.Add(entry);
            }
            return result;
        }

        public List<Artist> GetArtistsByAlbumId(int id)
        {
            List<Artist> result = new List<Artist>();
            var reader = GetReader("result");
            while (reader.Read())
            {
                Artist entry = new Artist((int)reader[0], (string)reader[1]);
                result.Add(entry);
            }
            return result;
        }

        public List<Playlist> GetPlaylists(string name)
        {
            List<Playlist> result = new List<Playlist>();
            var reader = GetReader(@"SELECT playlistID, playlistName, date 
                                     FROM Playlist WHERE playlistName LIKE '%" + name + "%'");
            while (reader.Read())
            {
                Playlist entry = new Playlist((int)reader[0], (string)reader[1], (DateTime)reader[2]);
                result.Add(entry);
            }
            return result;
        }

        public List<Concert> GetConcert(string name)
        {
            List<Concert> result = new List<Concert>();
            var reader = GetReader(@"SELECT ConcertID, concertName, location, date
                                     FROM Concert WHERE ConcertName LIKE '%" + name + "%'");
            while (reader.Read())
            {
                Concert entry = new Concert((int)reader[0], (string)reader[1], (string)reader[2], (DateTime)reader[3]);
                result.Add(entry);
            }
            return result;
        }

        public List<Album> GetAlbumsByName(string name)
        {
            List<Album> result = new List<Album>();
            var reader = GetReader("result");
            while (reader.Read())
            {
                Album entry = new Album((int)reader[0], (string)reader[1], (DateTime)reader[2]);
                result.Add(entry);
            }
            return result;
        }

        public List<Album> GetAlbumsByArtistId(int id)
        {
            List<Album> result = new List<Album>();
            var reader = GetReader("result");
            while (reader.Read())
            {
                Album entry = new Album((int)reader[0], (string)reader[1], (DateTime)reader[2]);
                result.Add(entry);
            }
            return result;
        }

        public List<Album> GetAlbumsBySongId(int id)
        {
            List<Album> result = new List<Album>();
            var reader = GetReader("result");
            while (reader.Read())
            {
                Album entry = new Album((int)reader[0], (string)reader[1], (DateTime)reader[2]);
                result.Add(entry);
            }
            return result;
        }

        public List<Song> GetSongsByName(string name)
        {
            List<Album> result = null;
            var reader = GetReader("result");
            while (reader.Read())
            {
                Song entry = new Song((int)reader[0], (string)reader[1], (TimeSpan)reader[2]);
                result.Add(entry);
            }
            return result;
        }

        public List<Song> GetSongsByAlbumId(int id)
        {
            List<Song> result = null;
            var reader = GetReader("SELECT ");
            while (reader.Read())
            {
                Song entry = new Song((int)reader[0], (string)reader[1], (TimeSpan)reader[2]);
                result.Add(entry);
            }
            return result;
        }
    }
}
