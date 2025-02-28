using TableTogether.Domain.Common.Models;

namespace TableTogether.Domain.Host.ValueObjects;

public sealed class HostId : ValueObject
{
    public Guid Value { get; }
    
    private HostId(Guid value)
    {
        Value = value;
    }

    public static HostId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public static HostId Create(string id)
    {
        return new(Guid.Parse(id));
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}