using System;

namespace MediaApp.API.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string FilmedBy { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsFavorite { get; set; }
        public string PublicId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}