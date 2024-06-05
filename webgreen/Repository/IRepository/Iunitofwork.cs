namespace webgreen.Repository.IRepository
{
    public interface Iunitofwork
    {
        ICatsRepository Cats { get; }
        void save();
    }
}
