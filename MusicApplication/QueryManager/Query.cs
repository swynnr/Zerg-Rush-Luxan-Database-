﻿using System;
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
            string connStr = string.Format("Server={0}; database={1}; UID={2}; password={3}; convert zero datetime=True", host, db, username, password);
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
            string cmd = string.Format(@"INSERT INTO Playlist (playlistName, date) 
                            VALUES ('{0}', '{1}');", playlist.PlaylistName, playlist.Date.ToString(FORMAT_DATE));
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

            string cmd = string.Format("INSERT INTO Concert(concertName, location, date" +
                         "VALUES('{0}', '{1}', '{2}');",
                         concert.ConcertName, concert.Location,concert.Date.ToString(FORMAT_DATE));

            ExecuteNonQuery(cmd);
            return true;
        }


        public void PlaylistAddSong(Playlist playlist, Song song)

        {
            string cmd = string.Format(@"INSERT INTO PlaylistxSong
                                         VALUES ({0}, {1});", playlist.PlaylistId, song.SongId);
            ExecuteNonQuery(cmd);
        }

        public void ConcertAddSong(Concert concert, Song song)
        {

            string cmd = string.Format(@"INSERT INTO ConcertxSong
                                         VALUES ({0}, {1});", concert.ConcertId, song.SongId);
            ExecuteNonQuery(cmd);
        }

        public void PlaylistRemoveSong(Playlist playlist, Song song)
        {
            string cmd = string.Format(@"DELETE FROM PlaylistxSong 
                                         WHERE playlistID = {0} AND songID = {1}", playlist.PlaylistId, song.SongId);
            ExecuteNonQuery(cmd);
        }

        public void ConcertRemoveSong(Concert concert, Song song)
        {
            string cmd = string.Format(@"DELETE FROM ConcertxSong 
                                         WHERE concertID = {0} AND songID = {1}", concert.ConcertId, song.SongId);
            ExecuteNonQuery(cmd);
        }

        public void DeletePlaylist(Playlist playlist)
        {
            string cmd = string.Format(@"DELETE FROM Playlist
                                         WHERE playlistID = {0}", playlist.PlaylistId);
            ExecuteNonQuery(cmd);
        }

        public void DeleteConcert(Concert concert)
        {
            string cmd = string.Format(@"DELETE FROM Concert
                                         WHERE concertID = {0}", concert.ConcertId);
            ExecuteNonQuery(cmd);
        }

        public List<Artist> GetArtistsByName(string name)
        {
            List<Artist> result = new List<Artist>();
            var reader = GetReader(@"SELECT artistID, artistName 
                                     FROM Artists WHERE artistName LIKE '%" + name + "%'");
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
            var reader = GetReader(@"SELECT artistID, artistName
                                     FROM Artists WHERE artistID LIKE '%" + id + "%'");
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
            var reader = GetReader(@"SELECT artistID, artistName
                                     FROM Artist ar
                                     JOIN AlbumxArtist axa ON
                                          ar.artistID = axa.artistID
                                     WHERE albumID = " + id);
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

            var reader = GetReader(@"SELECT playlistID, playlistName, date 
                                     FROM Playlist WHERE playlistName LIKE '%" + name + "%'");
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


            var reader = GetReader(@"SELECT ConcertID, concertName, location, date
                                     FROM Concert WHERE ConcertName LIKE '%" + name + "%'");

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
            var reader = GetReader(@"SELECT albumID, albumName, releaseDate 
                                     FROM Album WHERE albumName LIKE '%" + name + "%'");
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
            var reader = GetReader(@"SELECT albumID, albumName, releaseDate
                                     FROM Album a 
                                     JOIN AlbumxArtist axa ON
                                          a.artistID = axa.artistID
                                     WHERE artistID = " + id);
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
            var reader = GetReader(@"SELECT albumID, albumName, releaseDate
                                     FROM Album a 
                                     JOIN Songs s ON
                                          a.album = s.albumID
                                     WHERE songID = " + id);
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

            var reader = GetReader(@"SELECT songID, songName, songLength
                                     FROM Songs WHERE songName LIKE '%" + name + "%'");

            List<Song> result = new List<Song>();
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
            var reader = GetReader(@"SELECT songID, songName, songLength
                                     FROM Songs WHERE albumId = " + id);
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
            var reader = GetReader(@"SELECT s.songID, s.songName, s.songLength
                                     FROM Songs s
                                     JOIN ConcertxSong c ON c.songID = s.songID 
                                     WHERE c.concertID = " + id);
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
            var reader = GetReader(@"SELECT s.songID, s.songName, s.songLength
                                     FROM Songs s
                                     JOIN PlaylistxSong p ON p.songID = s.songID 
                                     WHERE p.playlistID = " + id);
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
    }
}
