using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using MusicApplication.Data;
using System.Security.Permissions;


namespace QueryManager
{
    public class Query
    {
        private MySqlConnection connection = null;
        private const string FORMAT_DATE = "yyy-MM-dd HH:mm:ss.fff";
        public Query(string host, string db, string username, string password)
        {
            try
            {
                string connStr = string.Format("Server={0}; database={1}; UID={2}; password={3}; convert zero datetime=True", host, db, username, password);
                connection = new MySqlConnection(connStr);
                connection.Open();
            }
            catch (MySqlException e)
            {
                throw e;
            }

        }
        private MySqlDataReader GetReader(string query)
        {
            try
            {
                var cmd = new MySqlCommand(query, connection);
                return cmd.ExecuteReader();
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        private void ExecuteNonQuery(string command)
        {
            try
            {
                var cmd = new MySqlCommand(command, connection);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        private string InjectionSanitizer(string cmd)
        {
            cmd = MySql.Data.MySqlClient.MySqlHelper.EscapeString(cmd);
            return cmd;
        }

        /// <summary>
        /// This method should take in a playlist object, create the playlist in the DB using the other
        /// parameters, then fill the playlist object with the proper id
        /// </summary>
        /// <param name="playlist"></param>
        /// <returns>Whether the playlist was created or not</returns>
        public int CreatePlaylist(ref Playlist playlist)
        {
            int id = -1;
            string cmd = string.Format(@"INSERT INTO Playlist (playlistName, date) 
                            VALUES ('{0}', '{1}');", InjectionSanitizer(playlist.PlaylistName), playlist.Date.ToString(FORMAT_DATE));
            ExecuteNonQuery(cmd);
            var reader = GetReader(@"SELECT MAX(playlistID)
                                     FROM Playlist"); ;
            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            reader.Close();
            return id;
        }

        /// <summary>
        /// This method should take in a concert, create the concert in the DB using the other
        /// parameters, then fill the concert object with the proper id
        /// </summary>
        /// <param name="concert"></param>
        /// <returns>Whether the concert was created or not</returns>
        public int CreateConcert(ref Concert concert)
        {
            int id = -1;
            string cmd = string.Format(@"INSERT INTO Concert(concertName, location, date)
                                         VALUES('{0}', '{1}', '{2}');", InjectionSanitizer(concert.ConcertName), InjectionSanitizer(concert.Location), concert.Date.ToString(FORMAT_DATE));
            ExecuteNonQuery(cmd);
            var reader = GetReader(@"SELECT MAX(concertID)
                                     FROM Concert;");
            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            reader.Close();
            return id;
        }


        public void PlaylistAddSong(Playlist playlist, Song song)

        {
            string cmd = string.Format(@"INSERT INTO PlaylistxSong
                                         VALUES ({0}, {1});", playlist.PlaylistId, song.SongId);
            ExecuteNonQuery(cmd);
        }

        public void ConcertAddSong(Concert concert, Song song)
        {
            string cmd = string.Format(@"INSERT INTO ConcertxSong(concertID, songID)
                                         VALUES ({0}, {1});", concert.ConcertId, song.SongId);
            ExecuteNonQuery(cmd);
        }

        public void PlaylistRemoveSong(Playlist playlist, Song song)
        {
            string cmd = string.Format(@"DELETE FROM PlaylistxSong 
                                         WHERE playlistID = {0} AND songID = {1};", playlist.PlaylistId, song.SongId);
            ExecuteNonQuery(cmd);
        }

        public void ConcertRemoveSong(Concert concert, Song song)
        {
            string cmd = string.Format(@"DELETE FROM ConcertxSong 
                                         WHERE concertID = {0} AND songID = {1};", concert.ConcertId, song.SongId);
            ExecuteNonQuery(cmd);
        }

        public void DeletePlaylist(Playlist playlist)
        {
            string cmd = string.Format(@"DELETE FROM Playlist
                                         WHERE playlistID = {0};", playlist.PlaylistId);
            ExecuteNonQuery(cmd);
        }

        public void DeleteConcert(Concert concert)
        {
            string cmd = string.Format(@"DELETE FROM Concert
                                         WHERE concertID = {0};", concert.ConcertId);
            ExecuteNonQuery(cmd);
        }

        public List<Artist> GetArtistsByName(string name)
        {
            List<Artist> result = new List<Artist>();
            string cmd = string.Format(@"SELECT artistID, artistName 
                                     FROM Artists WHERE artistName LIKE '%{0}%';", InjectionSanitizer(name));
            var reader = GetReader(cmd);
            while (reader.Read())
            {
                Artist entry = new Artist
                (
                    reader.GetInt32(0),
                    reader.GetString(1)
                );
                result.Add(entry);
            }
            reader.Close();
            return result;
        }

        public List<Artist> GetArtistsBySongId(int id)
        {
            List<Artist> result = new List<Artist>();
            string cmd = string.Format(@"SELECT a.artistID, a.artistName
                                     FROM Artists a
                                     JOIN ArtistxSongs as ON as.artistID = a.artistID
                                     WHERE as.songID = {0};", id);

            var reader = GetReader(cmd);
            
            
            while (reader.Read())
            {
                Artist entry = new Artist
                (
                    reader.GetInt32(0),
                    reader.GetString(1)
                );
                result.Add(entry);
            }
            reader.Close();
            return result;
        }

        public List<Artist> GetArtistsByAlbumId(int id)
        {
            List<Artist> result = new List<Artist>();
            string cmd = string.Format(@"SELECT artistID, artistName
                                     FROM Artist ar
                                     JOIN AlbumxArtist axa ON
                                          ar.artistID = axa.artistID
                                     WHERE albumID = {0};", id);
            var reader = GetReader(cmd);
            while (reader.Read())
            {
                Artist entry = new Artist
                (
                    reader.GetInt32(0),
                    reader.GetString(1)
                );
                result.Add(entry);
            }
            reader.Close();
            return result;
        }

        public List<Playlist> GetPlaylists(string name)
        {
            List<Playlist> result = new List<Playlist>();

            string cmd = string.Format(@"SELECT playlistID, playlistName, date 
                                     FROM Playlist WHERE playlistName LIKE '%{0}%';", InjectionSanitizer(name));

            var reader = GetReader(cmd);

            while (reader.Read())
            {
                Playlist entry = new Playlist
                (
                    reader.GetDateTime(2),
                    reader.GetString(1),
                    reader.GetInt32(0)
                );
                result.Add(entry);
            }
            reader.Close();
            return result;
        }

        public List<Concert> GetConcert(string name)
        {
            List<Concert> result = new List<Concert>();

            string cmd = string.Format(@"SELECT ConcertID, concertName, location, date
                                     FROM Concert WHERE ConcertName LIKE '%{0}%';", InjectionSanitizer(name));

            var reader = GetReader(cmd);

            while (reader.Read())
            {
                Concert entry = new Concert
                (
                    reader.GetDateTime(3),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetInt32(0)
                );
                result.Add(entry);
            }
            reader.Close();
            return result;
        }

        public List<Album> GetAlbumsByName(string name)
        {
            List<Album> result = new List<Album>();
            
            string cmd = string.Format(@"SELECT albumID, albumName, releaseDate 
                                     FROM Album WHERE albumName LIKE '%{0}%';", InjectionSanitizer(name));

            var reader = GetReader(cmd);
            while (reader.Read())
            {
                Album entry = new Album
                 (
                     reader.GetInt32(0),
                     reader.GetString(1),
                     reader.GetDateTime(2)
                 );
                result.Add(entry);
            }
            reader.Close();
            return result;
        }

        public List<Album> GetAlbumsByArtistId(int id)
        {
            List<Album> result = new List<Album>();
            
            string cmd = string.Format(@"SELECT albumID, albumName, releaseDate
                                     FROM Album a 
                                     JOIN AlbumxArtist axa ON
                                          a.artistID = axa.artistID
                                     WHERE artistID = {0};", id);

            var reader = GetReader(cmd);
            while (reader.Read())
            {
                Album entry = new Album
                (
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetDateTime(2)
                );
                result.Add(entry);
            }
            reader.Close();
            return result;
        }

        public List<Album> GetAlbumsBySongId(int id)
        {
            List<Album> result = new List<Album>();

            string cmd = string.Format(@"SELECT albumID, albumName, releaseDate
                                     FROM Album a 
                                     JOIN Songs s ON
                                          a.album = s.albumID
                                     WHERE songID = {0};", id);
            var reader = GetReader(cmd);
            while (reader.Read())
            {
                Album entry = new Album
                (
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetDateTime(2)
                );
                result.Add(entry);
            }
            reader.Close();
            return result;
        }

        public List<Song> GetSongsByName(string name)
        {
            List<Song> result = new List<Song>();
            string cmd = string.Format(@"SELECT songID, songName, songLength
                                     FROM Songs WHERE songName LIKE '%{0}%';", InjectionSanitizer(name));



            var reader = GetReader(cmd);
            
            while (reader.Read())
            {
                Song entry = new Song
                (
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetTimeSpan(2)
                );
                result.Add(entry);
            }
            reader.Close();
            return result;
        }

        public List<Song> GetSongsByAlbumId(int id)
        {
            List<Song> result = new List<Song>();

            string cmd = string.Format(@"SELECT songID, songName, songLength
                                     FROM Songs WHERE albumId = {0};", id);


            var reader = GetReader(cmd);
            while (reader.Read())
            {
                Song entry = new Song
                (
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetTimeSpan(2)
                );
                result.Add(entry);
            }
            reader.Close();
            return result;
        }
        public List<Song> GetSongsByConcertId(int id)
        {
            List<Song> result = new List<Song>();
            
            string cmd = string.Format(@"SELECT s.songID, s.songName, s.songLength
                                     FROM Songs s
                                     JOIN ConcertxSong c ON c.songID = s.songID 
                                     WHERE c.concertID = {0};", id);


            var reader = GetReader(cmd);
            while (reader.Read())
            {
                Song entry = new Song
                (
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetTimeSpan(2)
                );
                result.Add(entry);
            }
            reader.Close();
            return result;
        }

        public List<Song> GetSongsByPlaylistId(int id)
        {
            List<Song> result = new List<Song>();

            string cmd = string.Format(@"SELECT s.songID, s.songName, s.songLength
                                     FROM Songs s
                                     JOIN PlaylistxSong p ON p.songID = s.songID 
                                     WHERE p.playlistID = {0};", id);

            var reader = GetReader(cmd);
            while (reader.Read())
            {
                Song entry = new Song
                (
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetTimeSpan(2)
                );
                result.Add(entry);
            }
            reader.Close();
            return result;
        }

        public TimeSpan GetPlaylistLength(int id)
        {
            TimeSpan result = new TimeSpan();
            string cmd = string.Format(@"SELECT SUM(s.songLength)
                                     FROM Songs s
                                     JOIN PlaylistxSong p ON p.songID = s.songID 
                                     WHERE p.playlistID = {0};", id);

            var reader = GetReader(cmd);
            if(reader.Read())
            {
                result = reader.GetTimeSpan(0);
            }
            reader.Close();
            return result;
        }
    }
}
