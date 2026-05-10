using System.ComponentModel.DataAnnotations;

namespace onlinestore.Models
{
    public class Actor
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Pifture URL")]
        [Required(ErrorMessage ="Profile Picture is Required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name ="Biography")]
        [Required(ErrorMessage = "Biography is Required")]
        public string Bio { get; set; }

        [Display(Name ="Full Name")]
        [Required(ErrorMessage = "Fullname is Required")]
        public string FullName { get; set; }

        //relation
        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
