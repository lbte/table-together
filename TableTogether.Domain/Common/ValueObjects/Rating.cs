using TableTogether.Domain.Common.Models;

namespace TableTogether.Domain.Common.ValueObjects;

public sealed class Rating : ValueObject
{
    private Rating(double value)
    {
        Value = value;
    }

    public double Value { get; private set; }

    public static Rating CreateNew(double value = 0)
    {
        return new(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}