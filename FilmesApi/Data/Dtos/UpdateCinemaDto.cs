using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos
{
    public class UpdateCinemaDto
    {
        [Required(ErrorMessage = "Ocampo de nome é obrigatorio")]
        public string Nome { get; set; }
    }
}
