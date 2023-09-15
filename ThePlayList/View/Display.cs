using System;
using System.Collections.Generic;
using ThePlayList.Model;

namespace ThePlayList.View
{
    /// <summary>
    /// Contorls the display.
    /// </summary>
    internal static class Display
    {
        /// <summary>
        /// Output the app header.
        /// </summary>
        public static void Header()
        {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(":::::::::"); Console.ForegroundColor = ConsoleColor.White; Console.Write("——"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(":::"); Console.ForegroundColor = ConsoleColor.White; Console.Write("————————————"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(":::"); Console.ForegroundColor = ConsoleColor.White; Console.Write("———"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(":::"); Console.ForegroundColor = ConsoleColor.White; Console.Write("———"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(":::"); Console.ForegroundColor = ConsoleColor.White; Console.Write("——————"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(":::"); Console.ForegroundColor = ConsoleColor.White; Console.Write("————————"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(":::::::::::"); Console.ForegroundColor = ConsoleColor.White; Console.Write("—"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("::::::::"); Console.ForegroundColor = ConsoleColor.White; Console.Write("—"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(":::::::::::");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(":+:    :+: :+:          :+: :+: :+:   :+:      :+:            :+:    :+:    :+:    :+:    ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("+:+"); Console.ForegroundColor = ConsoleColor.White; Console.Write("————"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("+:+"); Console.ForegroundColor = ConsoleColor.White; Console.Write("—"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("+:+"); Console.ForegroundColor = ConsoleColor.White; Console.Write("—————————"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("+:+"); Console.ForegroundColor = ConsoleColor.White; Console.Write("———"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("+:+"); Console.ForegroundColor = ConsoleColor.White; Console.Write("—"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("+:+"); Console.ForegroundColor = ConsoleColor.White; Console.Write("—"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("+:+"); Console.ForegroundColor = ConsoleColor.White; Console.Write("———————"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("+:+"); Console.ForegroundColor = ConsoleColor.White; Console.Write("————————————"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("+:+"); Console.ForegroundColor = ConsoleColor.White; Console.Write("————"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("+:+"); Console.ForegroundColor = ConsoleColor.White; Console.Write("———————————"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("+:+"); Console.ForegroundColor = ConsoleColor.White; Console.Write("————"); Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("+#++:++#+  +#+        +#++:++#++: +#++:        +#+            +#+    +#++:++#++    +#+    ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("+#+"); Console.ForegroundColor = ConsoleColor.White; Console.Write("————————"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("+#+"); Console.ForegroundColor = ConsoleColor.White; Console.Write("————————"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("+#+"); Console.ForegroundColor = ConsoleColor.White; Console.Write("—————"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("+#+"); Console.ForegroundColor = ConsoleColor.White; Console.Write("——"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("+#+"); Console.ForegroundColor = ConsoleColor.White; Console.Write("—————————"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("+#+"); Console.ForegroundColor = ConsoleColor.White; Console.Write("————————————"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("+#+"); Console.ForegroundColor = ConsoleColor.White; Console.Write("———————————"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("+#+"); Console.ForegroundColor = ConsoleColor.White; Console.Write("————"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("+#+"); Console.ForegroundColor = ConsoleColor.White; Console.Write("————"); Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("#+#        #+#        #+#     #+#  #+#         #+#            #+#    #+#    #+#    #+#    ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("###"); Console.ForegroundColor = ConsoleColor.White; Console.Write("————————"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("##########"); Console.ForegroundColor = ConsoleColor.White; Console.Write("—"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("###"); Console.ForegroundColor = ConsoleColor.White; Console.Write("—————"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("###"); Console.ForegroundColor = ConsoleColor.White; Console.Write("——"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("###"); Console.ForegroundColor = ConsoleColor.White; Console.Write("—————————"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("##########"); Console.ForegroundColor = ConsoleColor.White; Console.Write("—"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("###########"); Console.ForegroundColor = ConsoleColor.White; Console.Write("—"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("########"); Console.ForegroundColor = ConsoleColor.White; Console.Write("—————"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("###"); Console.ForegroundColor = ConsoleColor.White; Console.Write("————"); Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.ResetColor();
        }

        /// <summary>
        /// Display the main menu.
        /// </summary>
        public static void MainMenu()
        {
            Console.Clear();
            Header();
            Console.WriteLine("==========================================================================================");
            Console.WriteLine("                                  Welcome to the Radio Station!");
            Console.WriteLine("==========================================================================================");
            Console.WriteLine("1. Create New Play List");
            Console.WriteLine("2. View Play Lists");
            Console.WriteLine("3. Delete Play Lists");
            Console.WriteLine("4. Exit");
            Console.WriteLine();
        }

        /// <summary>
        /// display the book inventory menu.
        /// </summary>
        /// <param name="books"></param>
        public static void NewTrackListMenu(PlayList tracks)
        {
            Console.Clear();
            int i = 1;
            Header();
            Console.WriteLine("==========================================================================================");
            Console.WriteLine("                                  Music Inventory");
            Console.WriteLine("==========================================================================================");
            foreach (Track track in tracks.Tracks)
            {
                Console.WriteLine($"{i}. {track}");
                i++;
            }
            Console.WriteLine($"{i}. Exit");
            Console.WriteLine();
        }
        /// <summary>
        /// display the book inventory menu.
        /// </summary>
        /// <param name="books"></param>
        public static void EditTrackListMenu(List<PlayList> playLists)
        {
            Console.Clear();
            int i = 1;
            Header();
            Console.WriteLine("==========================================================================================");
            Console.WriteLine("                                   Your Play Lists");
            Console.WriteLine("==========================================================================================");
            foreach (PlayList playList in playLists)
            {
                Console.WriteLine($"{i}. {playList.Name}");
                i++;
            }
            Console.WriteLine($"{i}. Exit");
            Console.WriteLine();
        }

        /// <summary>
        /// prompt the user for a numeric input.
        /// </summary>
        /// <returns>int</returns>
        public static int Input()
        {
            Console.WriteLine("Enter number to select menu item.");
            while (true)
            {
                try
                {
                    return Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("NaN: PLease enter a number, which must be in the menu!");
                }
            }
        }
        
        /// <summary>
        /// Prompt user for name of the playlist.
        /// </summary>
        /// <returns></returns>
        public static string InputName()
        {
            Console.WriteLine("What would you like to call your playlist?");
            return Console.ReadLine();
        }

        /// <summary>
        /// await for the user to press any key.
        /// </summary>
        internal static void Await()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        /// <summary>
        /// print message to the console.
        /// </summary>
        /// <param name="msg"></param>
        public static void Print(string msg)
        {
            Console.WriteLine($"{msg}");
        }
    }
}
