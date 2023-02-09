using OSManager.Model.Enums;

namespace OSManager.Model
{
    public class Tecnico: Pessoa
    {

        public ICollection<OrderService> OrderServices { get; set; }

        public Tecnico()
        {
            this.Perfil = Enums.EPerfil.TECNICO;
        }

        public Tecnico(string name, EPerfil perfil, string telefone, string cpf, string password, string urlImage)
        {
            this.Name = name;
            this.Perfil = EPerfil.TECNICO;
            this.Telefone = telefone;
            this.Cpf = cpf;
            this.Password = password;
            this.UrlImage = urlImage;
        }
    }
}
