using System.Collections.Generic;

namespace MustafaMistik.Models
{
    public class Catagory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<MeetMenu> MeetMenus { get; set; }
    }
}
