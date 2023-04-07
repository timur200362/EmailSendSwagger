namespace Dogs.WebApi.Models
{
    public class Dog
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public Family Family { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }

    }
}
