using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace booking_api.Model
{
    [Table("Compras")]
    public class Compras
    {
        [Key]
        public int Id_Compra { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir a data da compra")]
        public DateTime Data_Compra { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir o método de pagamento")]
        public string Metodo_Pagamento { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir o preço da compra")]
        public double Preco_Compra { get; set; }

        [ForeignKey("Clientes")]
        public int Id_Cliente { get; set; }

        public Clientes Clientes { get; set; }
        [ForeignKey("Passagens")]
        public int Id_Passagem { get; set; }
        public Passagens Passagens { get; set; }
    }
}
