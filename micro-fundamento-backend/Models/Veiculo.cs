using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace micro_fundamento_backend.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome obrigatorio")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Placa obrigatorio")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "AnoFabricacao obrigatorio")]
        [Display(Name = "Ano De Fabricação")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "AnoModelo obrigatorio")]
        [Display(Name = "Ano Do Modelo")]
        public int AnoModelo{ get; set; }

    }
}
