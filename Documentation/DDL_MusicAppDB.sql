﻿create table if not exists Album
(
    albumID     int auto_increment
        primary key,
    albumName   varchar(40) not null,
    releaseDate date        not null
);

create table if not exists Artists
(
    artistID   int auto_increment
        primary key,
    artistName varchar(40) not null
);

create table if not exists AlbumxArtist
(
    albumID  int not null,
    artistID int not null,
    constraint `Album/Artist_albumID_fk`
        foreign key (albumID) references Album (albumID),
    constraint `Album/Artist_artistID_fk`
        foreign key (artistID) references Artists (artistID)
);

create table if not exists Concert
(
    concertID   int auto_increment
        primary key,
    concertName varchar(40) not null,
    location    varchar(40) not null,
    date        datetime    not null
);

create table if not exists Playlist
(
    playlistID   int auto_increment
        primary key,
    playlistName varchar(40) not null,
    date         datetime    not null
);

create table if not exists Songs
(
    songID     int auto_increment
		primary key,
    songName   varchar(40) not null,
    albumID    int         not null,
    songLength time        not null,
    constraint Songs_songID_uindex
        unique (songID),
    constraint Songs_songName_uindex
        unique (songName),
    constraint `Songs/Album_albumID_fk`
        foreign key (albumID) references Album (albumID)
);

create table if not exists ArtistxSongs
(
    artistID int not null,
    songID   int not null,
    constraint `Artist/Songs_artistID_fk`
        foreign key (artistID) references Artists (artistID),
    constraint `Artist/Songs_songID_fk`
        foreign key (songID) references Songs (songID)
);

create table if not exists ConcertxSong
(
    concertID int not null,
    songID    int not null,
    constraint `Concert/Song_concertID_fk`
        foreign key (concertID) references Concert (concertID)
            on delete cascade,
    constraint `Concert/Song_songID_fk`
        foreign key (songID) references Songs (songID)
            on delete cascade
);

create table if not exists PlaylistxSong
(
    playlistID int not null,
    songID     int not null,
    constraint `Playlist/Song_playlistID_fk`
        foreign key (playlistID) references Playlist (playlistID)
            on delete cascade,
    constraint `Playlist/Song_songID_fk`
        foreign key (songID) references Songs (songID)
            on delete cascade
);

