using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace FilmesApi.Models
{
    public class Sessao
    {
        [Key]
        [Required]
        public int Id { get; set; }      

    }
}
