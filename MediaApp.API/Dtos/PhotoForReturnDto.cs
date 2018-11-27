using System;

namespace MediaApp.API.Dtos
{
    public class PhotoForReturnDto
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsFavorite { get; set; }
        public string PublicId { get; set; }
    }
}