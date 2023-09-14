namespace CQRSMediatR.Api.Abstraction
{
    public abstract class EntityBase
    {
        protected Guid Id { get; private set; }
        protected string Nome { get; private set; }

        protected EntityBase(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
        }

        public Guid GetId()
        {
            return Id;
        }

        public string GetNome()
        {
            return Nome;
        }

    }
}