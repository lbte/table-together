using TableTogether.Domain.Common.Models;

namespace TableTogether.Domain.Guest.ValueObjects;

public sealed class GuestId : ValueObject
{
    public Guid Value { get; }
    
    private GuestId(Guid value)
    {
        Value = value;
    }

    public static GuestId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}