using OSManager.Model.Enums;

namespace OSManager.Model
{
    public abstract class Pessoa
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EPerfil Perfil { get; set; } 
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string Password { get; set; }
        public string UrlImage { get; set; }
        public DateTime DataCriacao { get; set; }

        public Pessoa()
        {
            DataCriacao =  DateTime.Now;
        }

    }
}
