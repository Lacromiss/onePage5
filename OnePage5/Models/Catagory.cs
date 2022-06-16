namespace OnePage5.Models
{
    public class Catagory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ToEatId { get; set; }
        public ToEat ToEat { get; set; }
    }
}
