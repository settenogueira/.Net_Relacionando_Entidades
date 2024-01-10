using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace FilmesApi.Models
{
    public class Sessao
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int FilmeId { get; set; }
        public virtual Filme Filme { get; set; }    
    }
}
