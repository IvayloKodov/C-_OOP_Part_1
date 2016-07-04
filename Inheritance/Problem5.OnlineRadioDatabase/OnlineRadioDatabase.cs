using System;
using System.Collections.Generic;
using System.Linq;
using Problem5.OnlineRadioDatabase.Exceptions;

namespace Problem5.OnlineRadioDatabase
{
    public class OnlineRadioDatabase
    {
        public static void Main()
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            var allSongs = new List<Song>();
            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] songInfo = Console.ReadLine()
                                        .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    string artistName = songInfo[0];
                    string songName = songInfo[1];
                    long[] songLength = songInfo[2]
                        .Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(long.Parse)
                        .ToArray();

                    long minutes = songLength[0];
                    long seconds = songLength[1];
                    SongLength minsAndSecs = new SongLength(minutes, seconds);
                    Song song = new Song(artistName, songName, minsAndSecs);
                    allSongs.Add(song);
                    Console.WriteLine("Song added.");
                }
                catch (InvalidSongException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine(InvalidSongLengthException.Message);
                }
            }
            long playListLength = 0;
            foreach (var song in allSongs)
            {
                song.Length.CalculateTime();
                playListLength += song.Length.FullSongLengthInSeconds;
            }
            Console.WriteLine($"Songs added: {allSongs.Count}");

            long finalMinutes = playListLength / 60;
            long finalSeconds = playListLength % 60;
            long finalHours = playListLength / 3600;
            finalMinutes %= 60;

            Console.WriteLine("Playlist length: {0}h {1}m {2}s",
               finalHours, finalMinutes, finalSeconds);
        }
    }
}