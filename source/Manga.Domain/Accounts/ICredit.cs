namespace Manga.Domain.Accounts
{
    using Manga.Domain.ValueObjects;

    public interface ICredit : IEntity
    {
        Amount Add(Amount amount);
    }
}