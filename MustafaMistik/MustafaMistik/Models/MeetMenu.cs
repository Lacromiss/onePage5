using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace MustafaMistik.Models
{
    public class MeetMenu
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public int CatagoryId { get; set; }
        public Catagory Catagory { get; set; }
    }
}
