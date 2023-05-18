namespace DesignPatterns.OpenClosedPrinciple;

public interface ISpecification<T>
{
    bool IsSatisfied(T t);
}
