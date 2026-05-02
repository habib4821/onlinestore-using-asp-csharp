using System.ComponentModel.DataAnnotations;

namespace onlinestore.Models
{
    public class Actor
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Pifture URL")]
        public string ProfilePictureURL { get; set; }

        [Display(Name ="Biography")]
        public string Bio { get; set; }

        [Display(Name ="Full Name")]
        public string FullName { get; set; }

        //relation
        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
