using System;

namespace ThePlayList.Model
{
    /// <summary>
    /// <c>Track</c> models a song/track.
    /// </summary>
    internal class Track
    {
        private string _title;
        private string _artist;
        private TimeSpan _duration;
        private string _album;

        #region Constructors
        private Track()
        {
            Title = "";
            Artist = "";
            Duration = new TimeSpan();
            Album = "";
        }
        private Track(string title) : this()
        {
            Title = title;
        }
        private Track(string title, string artist) : this(title)
        {
            Artist = artist;
        }
        private Track(string title, string artist, TimeSpan duration) : this(title, artist)
        {
            Duration = duration;
        }

        /// <summary>
        /// Constructs a new Track.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="artist"></param>
        /// <param name="duration"></param>
        /// <param name="album"></param>
        public Track(string title, string artist, TimeSpan duration, string album) : this(title, artist, duration)
        {
            Album = album;
        }
        #endregion

        #region Properties
        
        /// <summary>
        /// The title of the track.
        /// </summary>
        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
            }
        }
        
        /// <summary>
        /// The name of the artist.
        /// </summary>
        public string Artist
        {
            get
            {
                return _artist;
            }

            set
            {
                _artist = value;
            }
        }

        /// <summary>
        /// The duration of the track.
        /// </summary>
        public TimeSpan Duration
        {
            get
            {
                return _duration;
            }

            set
            {
                _duration = value;
            }
        }

        /// <summary>
        /// The name of the album to which the track belongs.
        /// </summary>
        public string Album
        {
            get
            {
                return _album;
            }

            set
            {
                _album = value;
            }
        }
        #endregion

        //Override Object.ToString. Returns the title by artist.
        public override string ToString()
        {
            return $"{Title} by {Artist}";
        }
    }
}
