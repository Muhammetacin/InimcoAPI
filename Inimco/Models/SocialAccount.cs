using System.ComponentModel.DataAnnotations.Schema;

namespace Inimco.Models
{
    public class SocialAccount
    {
        public int Id { get; set; }
        public string Type { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

        [ForeignKey("PersonId")]
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
