using System;
using System.Collections.Generic;
using System.Text;

namespace SongApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Playlist
    {
        // Private list
        private readonly List<Song> _songs = new();

        // Add song
        public void Add(Song song)
        {
            if (song == null)
                throw new ArgumentNullException(nameof(song));
            else
             _songs.Add(song);
        }

        // Indexer
        public Song this[int index]
        {
            get { return _songs[index]; }
        }

        // Count property
        public int Count
        {
            get { return _songs.Count; }
        }

        // Computed property
        public int TotalDuration
        {
            get { return _songs.Sum(song => song.DurationSeconds); }
        }
    }

}
