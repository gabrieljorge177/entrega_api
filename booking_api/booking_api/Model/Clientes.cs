using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace booking_api.Model
{
    [Table("Clientes")]
    public class Clientes
    {

       

        [Key]
        public int Id_Cliente { get; set; }
        public int Acompanhantes { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir um CPF")]
        [MinLength(11, ErrorMessage = "Mínimo de 11 caracteres")]
        [MaxLength(11, ErrorMessage = "Máximo de 11 caracteres")]
        public string Cpf { get; set; }

        public int Idade { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir um email")]
        [MinLength(10, ErrorMessage = "Mínimo de 10 caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório escolher um nome")]
        [MinLength(2, ErrorMessage = "Mínimo de 2 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório escolher uma senha")]
        [MinLength(5, ErrorMessage = "Mínimo de 5 caracteres")]
        public string Senha { get; set; }

        [JsonIgnore]
        public List<Compras> Compras { get; set; }
    }
}
