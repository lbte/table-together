using TableTogether.Domain.Common.Models;

namespace TableTogether.Domain.Dinner.ValueObjects;

public sealed class Price : ValueObject
{
    public double Amount { get; }
    public string Currency { get; }
    
    private Price(
        double amount,
        string currency)
    {
        Amount = amount;
        Currency = currency;
    }

    public static Price Create(
        double amount,
        string currency)
    {
        return new(
            amount,
            currency
        );
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Amount;
        yield return Currency;
    }
}