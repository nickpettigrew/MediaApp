using System;

namespace MediaApp.API.Dtos
{
    public class PhotosForDetailedDto
    {
        public int ID { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsFavorite { get; set; }
    }
}