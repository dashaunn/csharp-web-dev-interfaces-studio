using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            CD renaissance = new CD("Renaissance", "Compact Disc (CD)", .7, 12, 52, "Music");
            DVD spongebobSeries = new DVD("Spongebob Seasons 1-13", "Digital Video Disc (DVD)", 4.7, 1, 24, "Movie");
            // TODO: Call each CD and DVD method to verify that they work as expected.
            List<string> newSongs = new List<string> { "ALIEN SUPERSTAR", "HEATED", "THIQUE", "MOVE", "SUMMER RENAISSANCE", "CHURCH GIRL" };
            List<string> episodes = new List<string> { "Episode 211", "Episode 212", "Episode 213", "Episode 214", "Episode 215", "Episode 216" };

            renaissance.SpinDisc();
            renaissance.ShowProperties();
            renaissance.WriteData(0.1, newSongs);
            renaissance.CheckRemainingCapacity();
            renaissance.ReadData();

            spongebobSeries.SpinDisc();
            spongebobSeries.ShowProperties();
            spongebobSeries.WriteData(1, episodes);
            spongebobSeries.CheckRemainingCapacity();
            spongebobSeries.ReadData();
        }
    }
}
