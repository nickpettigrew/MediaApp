using System;
using System.Collections.Generic;
using MediaApp.API.Models;

namespace MediaApp.API.Dtos
{
    public class UserForDetailedDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string BusinessName { get; set; }
        public string ABN { get; set; }
        public string ContactName { get; set; }
        public string Summary { get; set; }
        public string Industry { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime LastUploaded { get; set; }
        public string VideoUrl { get; set; }
        public ICollection<VideosForDetailedDto> Videos { get; set; }
        public string PhotoUrl { get; set; }
        public ICollection<PhotosForDetailedDto> Photos { get; set; }
    }
}