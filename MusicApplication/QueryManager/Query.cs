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

        public List<Artist> GetArtists(string name)
        {
            List<Artist> result = null;
            var reader = GetReader("result");
            while (reader.Read())
            {
                result.Add((Artist)Activator.CreateInstance(typeof(Artist), reader));
            }
            return result;
        }

        public List<Playlist> GetPlaylists(string name)
        {
            List<Playlist> result = null;
            var reader = GetReader("result");
            while (reader.Read())
            {
                result.Add((Playlist)Activator.CreateInstance(typeof(Playlist), reader));
            }
            return result;
        }

        public List<Concert> GetConcert(string name)
        {
            List<Concert> result = null;
            var reader = GetReader("result");
            while (reader.Read())
            {
                result.Add((Concert)Activator.CreateInstance(typeof(Concert), reader));
            }
            return result;
        }

        public List<Album> GetAlbums(string name)
        {
            List<Album> result = null;
            var reader = GetReader("result");
            while (reader.Read())
            {
                result.Add((Album)Activator.CreateInstance(typeof(Album), reader));
            }
            return result;
        }

        public List<Song> GetSongs(string name)
        {
            List<Song> result = null;
            var reader = GetReader("result");
            while (reader.Read())
            {
                result.Add((Song)Activator.CreateInstance(typeof(Song), reader));
            }
            return result;
        }
    }
}