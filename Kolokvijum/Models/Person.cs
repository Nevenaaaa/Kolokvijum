using System.ComponentModel.DataAnnotations;

namespace Kolokvijum.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public int Age { get; set; }

    }
}
