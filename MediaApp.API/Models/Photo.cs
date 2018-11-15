using System;

namespace MediaApp.API.Models
{
    public class Photo
    {
        public int ID { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsFavorite { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}