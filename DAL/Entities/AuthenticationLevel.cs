using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public class AuthenticationLevel
    {
        [Key]
        public int AuthId { get; set; }
        [Required]
        public string  AuthName { get; set; }

        [ForeignKey("AuthRefId")]
        public ICollection<User> Users { get; set; }


    }
}