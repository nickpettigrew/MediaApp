using System;
using Microsoft.AspNetCore.Http;

namespace MediaApp.API.Dtos
{
    public class VideoForCreationDto
    {
        public string Url {get; set; }
        public IFormFile File { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public string PublicId { get; set; }
        public VideoForCreationDto(){
            DateAdded = DateTime.Now;
        }
    }
}