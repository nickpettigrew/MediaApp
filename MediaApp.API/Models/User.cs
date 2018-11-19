using System;
using System.Collections.Generic;

namespace MediaApp.API.Models
{
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
        public string BusinessName { get; set; }
        public string ABN { get; set; }
        public string ContactName { get; set; }
        public string Summary { get; set; }
        public string Industry { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime LastUploaded { get; set; }
        public ICollection<Video> Videos { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}