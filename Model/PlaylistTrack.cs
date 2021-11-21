#nullable disable

namespace SQL_Assignment_2_Chinook.Model
{
    public partial class PlaylistTrack
    {
        public int PlaylistId { get; set; }
        public int TrackId { get; set; }

        public virtual Playlist Playlist { get; set; }
        public virtual Track Track { get; set; }
    }
}
