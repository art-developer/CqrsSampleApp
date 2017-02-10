namespace Art.Cqrs
{
    public interface IQuery<out TResult, in TCriterion>
    {
        TResult Execute(TCriterion criterion);
    }
}
