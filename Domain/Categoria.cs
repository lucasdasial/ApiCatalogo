using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CatalogApi.Domain
{
    public class Categoria
    {

        public Categoria()
        {
            Produtos = new Collection<Produto>();
        }
        [Key]
        public int CategoriaId { get; set; }

        [Required]
        [MaxLength(80)]
        public string? Nome { get; set; }

        [MaxLength(300)]
        public string? ImageUrl { get; set; }

        [JsonIgnore]
        public ICollection<Produto>? Produtos { get; set; }
    }
}
