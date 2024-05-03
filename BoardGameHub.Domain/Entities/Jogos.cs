using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace BoardGameHub.Domain.Entities
{
    public class Jogos
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]

		[MaxLength(50)]
        public required string Name { get; set; }

		[MaxLength(50)]
		[Display(Name = "Categoria")]
		public required string Category { get; set; }

		[Display(Name = "Descrição")]
		public string? Description { get; set; }

		[Display(Name = "Número de Jogadores")]
		[Range(1,20)]
		public int PlayerNumber { get; set; }

		[Display(Name = "Imagem")]
		public string? ImageUrl { get; set; }

		[Display(Name = "Adicional")]
		public string? Additional { get; set; }

    }
}
