namespace CQRSMediatR.Api.Abstraction
{
    public abstract class EntityBase
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }

        protected EntityBase(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
        }

    }
}