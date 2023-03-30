using System.ComponentModel.DataAnnotations.Schema;

namespace Inimco.Models
{
    public class SocialSkill
    {
        public int Id { get; set; }
        public string SkillName { get; set; } = string.Empty;

        [ForeignKey("PersonId")]
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
