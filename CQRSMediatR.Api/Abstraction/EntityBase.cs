namespace CQRSMediatR.Api.Abstraction
{
    public abstract class EntityBase
    {
        protected Guid Id { get; }
        protected string Nome { get; set; }

        protected EntityBase(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
        }

        public Guid GetId()
        {
            return Id;
        }
    }
}