using TableTogether.Domain.Common.Models;
using TableTogether.Domain.Common.ValueObjects;
using TableTogether.Domain.Dinner.ValueObjects;
using TableTogether.Domain.Guest.ValueObjects;
using TableTogether.Domain.Host.ValueObjects;

namespace TableTogether.Domain.Guest.Entities;

public sealed class GuestRating : Entity<RatingId>
{
    private GuestRating(
        RatingId id,
        HostId hostId,
        DinnerId dinnerId,
        Rating ratingValue,
        DateTime createdDateTime,
        DateTime updatedDateTime) : base(id)
    {
        HostId = hostId;
        DinnerId = dinnerId;
        RatingValue = ratingValue;
        CreatedDateTime = createdDateTime;
        UpdatedDateTime = updatedDateTime;
    }

    public HostId HostId { get; }
    public DinnerId DinnerId { get; }
    public Rating RatingValue { get; }
    public DateTime CreatedDateTime { get; }
    public DateTime UpdatedDateTime { get; }

    public static GuestRating Create(
        HostId hostId,
        DinnerId dinnerId,
        Rating ratingValue
    )
    {
        return new(
            RatingId.CreateUnique(),
            hostId,
            dinnerId,
            ratingValue,
            DateTime.UtcNow,
            DateTime.UtcNow);
    }
}