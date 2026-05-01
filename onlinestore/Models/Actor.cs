using System.ComponentModel.DataAnnotations;

namespace onlinestore.Models
{
    public class Actor
    {

        [Key]
        public int ActorId { get; set; }
        public string ProfilePictureURL { get; set; }
        public string Bio { get; set; }
        public string FullName { get; set; }

        //relation
        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
