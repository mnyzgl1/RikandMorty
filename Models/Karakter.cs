namespace RikendMorty.Models
{
   

        public class KarakterResult
        {
            public List<Karakter> results { get; set;}
        }
    public class Karakter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Species { get; set; }
        public string Gender { get; set; }
        public string Image { get; set; }
    }
    
}
