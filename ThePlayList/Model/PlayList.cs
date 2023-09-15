using System.Collections.Generic;
using System.Text;

namespace ThePlayList.Model
{
    /// <summary>
    /// <c>PlayList</c> models a play list.
    /// </summary>
    internal class PlayList
    {
        private string _name;
        private string _description;
        private LinkedList<Track> _tracks;

        #region Constructors
        private PlayList()
        {
            Name = "";
            Description = "";
            Tracks = new LinkedList<Track>();
        }

        /// <summary>
        /// Constructs a playlist with no description.
        /// </summary>
        /// <param name="name"></param>
        public PlayList(string name) : this()
        {
            Name = name;
        }

        /// <summary>
        /// Constructs a new playlist.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        public PlayList(string name, string description) : this(name)
        {
            Description = description;
        }

        /// <summary>
        /// Construct a new playlist with a tracklist.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="tracks"></param>

        public PlayList(string name, string description, LinkedList<Track> tracks) : this(name, description)
        {
            /** To ensure that we're getting a new Track list,
             * We're creating a new LinkedList<Track> and parsing the tracks to it's constructor.
             */
            Tracks = new LinkedList<Track>(tracks);
        }
        /// <summary>
        /// construct a new playlist with a tracklist but without a description.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="tracks"></param>
        public PlayList(string name, LinkedList<Track> tracks) : this(name)
        {
            /** To ensure that we're getting a new Track list,
             * We're creating a new LinkedList<Track> and parsing the tracks to it's constructor.
             */
            Tracks = new LinkedList<Track>(tracks);
        }
        #endregion

        #region Properties
        /// <summary>
        /// The name of the playlist.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        /// <summary>
        /// A description of the playlist.
        /// </summary>
        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }

        /// <summary>
        /// The tracks in the playlist.
        /// </summary>
        internal LinkedList<Track> Tracks
        {
            get
            {
                return _tracks;
            }

            set
            {
                _tracks = value;
            }
        }
        #endregion

        //Overrides to string. Returns a list of tracks by author.
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Track track in Tracks)
            {
                sb.AppendLine(track.ToString());
            }
            return sb.ToString();
        }
    }
}
