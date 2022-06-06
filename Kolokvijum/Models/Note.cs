using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokvijum.Models
{
    public class Note
    {
        [Key]
        public int NoteId { get; set; }
        [Required(ErrorMessage = "Ovo je neophodno polje")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Ovo je neophodno polje")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Ovo je neophodno polje")]


        public int CreatedAt { get; set; }
       


    } 

}
