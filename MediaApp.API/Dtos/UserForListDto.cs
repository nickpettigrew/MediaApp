using System;

namespace MediaApp.API.Dtos
{
    public class UserForListDto
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
    }
}