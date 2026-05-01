using System.ComponentModel.DataAnnotations;

namespace onlinestore.Models
{
    public class Producer
    {
        [Key]
        public int ProdId { get; set; }
        public string ProfilePictureURL { get; set; }
        public string Bio { get; set; }
        public string FullName { get; set; }


        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
 