namespace Art.Cqrs
{
    public interface IFindAllQuery<out TResult>
    {
        TResult Execute();
    }
}
