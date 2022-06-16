using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnePage5.Models
{
    public class ToEat
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public List<Catagory> Catagories { get; set; }

    }
}
