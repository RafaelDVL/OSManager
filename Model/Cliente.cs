using OSManager.Model.Enums;

namespace OSManager.Model
{
    public class Cliente: Pessoa
    {
        public ICollection<OrderService> OrderServices = new List<OrderService>();

        public Cliente()
        {
            this.Perfil = Enums.EPerfil.CLIENTE;    
        }

        public Cliente(string name, string telefone, string cpf, string password, string urlImage)
        {
            this.Name = name;
            this.Perfil = EPerfil.CLIENTE;
            this.Telefone = telefone;
            this.Cpf = cpf;
            this.Password = password;
            this.UrlImage = urlImage;
        }
    }
}
