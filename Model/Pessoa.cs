using OSManager.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace OSManager.Model
{
    public abstract class Pessoa
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public EPerfil Perfil { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string Cpf { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string UrlImage { get; set; }
        
        public DateTime DataCriacao { get; set; }

        public Pessoa()
        {
            DataCriacao =  DateTime.Now;
        }

    }
}
