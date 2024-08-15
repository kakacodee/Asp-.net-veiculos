using System.ComponentModel.DataAnnotations;

namespace AppQuarta.Models
{
    public class Veiculo
    {
        [Display(Name ="Marca do Veículo")]
        [Required(ErrorMessage ="A Marca é obrigatória")]
        public string Marca { get; set; }

        [Display(Name ="Nome do Veículo")]
        [Required(ErrorMessage ="O Nome do Veículo é obrigatório")]
        public string Nome { get; set; }

        [Display(Name ="Tipo do Veículo")]
        [Required(ErrorMessage ="O tipo do veículo é obrigatório")]
        public string Tipo { get; set; }

        [Display(Name ="Velocidade do Veículo(km)")]
        [Required(ErrorMessage = "A Velocidade é obrigatória")]
        [Range(1,1000, ErrorMessage ="A velocidade deve ser entre 1km e 1000km")]
        public int Velocidade { get; set; }

        [Display(Name ="Ano do Veículo")]
        [Required(ErrorMessage = "O Ano do Veículo é obrigatório")]
        [Range(2000,2024, ErrorMessage ="O veículo deve ser de 2000 no máximo")]
        public string Ano {  get; set; }

    }
}
