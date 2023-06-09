﻿namespace DesignPatterns.OpenClosedPrinciple;

public interface IFilter<T>
{
    IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> specs);
}
