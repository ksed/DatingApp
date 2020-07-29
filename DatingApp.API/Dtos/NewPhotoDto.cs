using System;
using Microsoft.AspNetCore.Http;

namespace DatingApp.API.Dtos
{
    public class NewPhotoDto
    {
        public string Url { get; set; }
        public IFormFile File { get; set; }
        public string Description { get; set; }
        public DateTime DateAddded { get; set; }
        public string PublicID { get; set; }
        public NewPhotoDto()
        {
            this.DateAddded = DateTime.Now.ToLocalTime();
        }
    }
}