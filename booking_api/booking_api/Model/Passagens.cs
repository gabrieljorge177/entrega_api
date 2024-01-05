using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace booking_api.Model
{
    [Table("Passagens")]
    public class Passagens
    {
        

        [Key]
        public int Id_Passagem { get; set; }
        [Required(ErrorMessage = "Obrigatório inserir uma cidade")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Obrigatório inserir uma categoria")]
        public string Categoria { get; set; }
        [Required(ErrorMessage = "Obrigatório inserir um valor para a passagem")]
        public double Preco { get; set; }
        [Required(ErrorMessage = "Obrigatório inserir uma data da passagem desejada")]
        public DateTime data_passagem { get; set; }

        [JsonIgnore]
        public List<Compras> Compras { get; set; }


    }
}