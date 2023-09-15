using System;
using System.Collections.Generic;
using ThePlayList.Model;
using ThePlayList.View;

namespace ThePlayList.Controller
{
    /// <summary>
    /// <c>RadioStation</c> Controls the music.
    /// </summary>
    internal static class RadioStation
    {
        public static void Open()
        {
            List<PlayList> playLists = new List<PlayList>();
            PlayList allTracks = new PlayList("All Tracks");
            for (int i = 0; i < 25; i++)
            {
                allTracks.Tracks.AddLast(new Track(Generator.TrackAlbumName(), Generator.GetRandomName(), Generator.GetRandomDuration(), Generator.TrackAlbumName()));
            }

            while (true)
            {
                Display.Header();
                Display.MainMenu();
                switch (Display.Input())
                {
                    case 1: //create new playlist
                        PlayList temp = new PlayList("temp", allTracks.Tracks);
                        PlayList newPlaylist = new PlayList(Display.InputName());
                        
                        //select tracks to add to the playlist.
                        while (true)
                        {
                            Display.NewTrackListMenu(temp);
                            int input = Display.Input();
                            
                            //if it's a track, add it to the list.
                            if (input != temp.Tracks.Count + 1)
                            {
                                int index = 0;
                                foreach (var track in temp.Tracks)
                                {
                                    if (index == input - 1) //the tracks is 0 indexed and the menu is 1 indexed.
                                    {
                                        newPlaylist.Tracks.AddLast(track);
                                        temp.Tracks.Remove(track);
                                        break;
                                    }
                                    index++;
                                }
                            }
                            else //if it's not a track, add the playlist to the playlists and exit.
                            {
                                playLists.Add(newPlaylist);
                                break;
                            }
                        }
                        break;

                    case 2: //display playlists
                        while (true)
                        {
                            Display.EditTrackListMenu(playLists);
                            int input = Display.Input();
                            //if the input is a playlist, display that playlist.
                            if (input != playLists.Count + 1)
                            {
                                Display.Print(playLists[input - 1].ToString()); //the playlists is 0 indexed and the menu is 1 indexed.
                                Display.Await();
                            }
                            else //else exit.
                            {
                                break;
                            }
                        }
                        break;

                    case 3: //Delete playlist
                        while (true)
                        {
                            Display.EditTrackListMenu(playLists);
                            int input = Display.Input();
                            //if the selected option is a playlist, delete it.
                            if (input != playLists.Count + 1)
                            {
                                playLists.RemoveAt(input - 1);
                            }
                            else //else exit.
                            {
                                break;
                            }
                        }
                        break;

                    case 4: //exit the application.
                        Environment.Exit(0);
                        break;
                }
                Display.Await();
            }
        }
    }
}
