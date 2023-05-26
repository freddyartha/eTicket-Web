using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public String ProfilePictureURl { get; set; }
        public String FullName { get; set; }
        public String Bio { get; set; }
    }
}
