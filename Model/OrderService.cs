using OSManager.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace OSManager.Model
{
    public class OrderService
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Descricao { get; set; }

        public EStatus status { get; set; }  

        public EPrioridade prioridade { get; set; }

        public int ClienteID { get; set; }
        public virtual Cliente Cliente { get; set; }

        public int TecnicoID { get; set; }
        public virtual Tecnico Tecnico { get; set; }

        public DateTime DataCriacao { get; set; }
        public DateTime DataFechamento { get; set; }



        public OrderService()
        {
            this.DataCriacao = DateTime.Now;
            this.status = EStatus.ABERTA;
        }

        public OrderService(int id, string descricao, EStatus status, EPrioridade prioridade, Cliente cliente, Tecnico tecnico)
        {
            Id = id;
            Descricao = descricao;
            this.status = status;
            this.prioridade = prioridade;
            Cliente = cliente;
            Tecnico = tecnico;
        }
    }

    
}
