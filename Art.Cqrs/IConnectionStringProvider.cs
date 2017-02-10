namespace Art.Cqrs
{
    public interface IConnectionStringProvider
    {
        string ConnectionString { get; }
    }
}
