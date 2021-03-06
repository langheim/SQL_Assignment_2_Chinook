using System.Collections.Generic;

#nullable disable

namespace SQL_Assignment_2_Chinook.Model
{
    public partial class Playlist
    {
        public Playlist()
        {
            PlaylistTracks = new HashSet<PlaylistTrack>();
        }

        public int PlaylistId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PlaylistTrack> PlaylistTracks { get; set; }
    }
}
