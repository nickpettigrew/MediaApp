using System;

namespace MediaApp.API.Dtos
{
    public class VideosForDetailedDto
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsFavorite { get; set; }
    }
}