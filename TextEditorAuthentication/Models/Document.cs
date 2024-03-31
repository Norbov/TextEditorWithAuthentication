using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TextEditorAuthentication.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        [Required]
        public string? UserId { get; set; }
        [ForeignKey("UserId")]
        public IdentityUser? User { get; set; }
    }
}
