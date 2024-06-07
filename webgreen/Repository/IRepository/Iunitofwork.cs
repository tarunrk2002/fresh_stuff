namespace webgreen.Repository.IRepository
{
    public interface Iunitofwork
    {
        ICatsRepository Cats { get; }
        IProductRepository Product { get; }
        void save();
    }
}
