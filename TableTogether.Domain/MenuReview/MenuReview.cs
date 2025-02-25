using TableTogether.Domain.Common.Models;
using TableTogether.Domain.Common.ValueObjects;
using TableTogether.Domain.Dinner.ValueObjects;
using TableTogether.Domain.Guest.ValueObjects;
using TableTogether.Domain.Host.ValueObjects;
using TableTogether.Domain.Menu.ValueObjects;
using TableTogether.Domain.MenuReview.ValueObjects;

namespace TableTogether.Domain.MenuReview;

public sealed class MenuReview : AggregateRoot<MenuReviewId>
{
    private MenuReview(
        MenuReviewId id,
        Rating rating,
        string comment,
        HostId hostId,
        MenuId menuId,
        GuestId guestId,
        DinnerId dinnerId,
        DateTime createdDateTime,
        DateTime updatedDateTime) : base(id)
    {
        Rating = rating;
        Comment = comment;
        HostId = hostId;
        MenuId = menuId;
        GuestId = guestId;
        DinnerId = dinnerId;
        CreatedDateTime = createdDateTime;
        UpdatedDateTime = updatedDateTime;
    }

    public Rating Rating { get; }
    public string Comment { get; }
    public HostId HostId { get; }
    public MenuId MenuId { get; }
    public GuestId GuestId { get; }
    public DinnerId DinnerId { get; }
    public DateTime CreatedDateTime { get; }
    public DateTime UpdatedDateTime { get; }

    public static MenuReview Create(
        Rating rating,
        string comment,
        HostId hostId,
        MenuId menuId,
        GuestId guestId,
        DinnerId dinnerId
    )
    {
        return new(
            MenuReviewId.CreateUnique(),
            rating,
            comment,
            hostId,
            menuId,
            guestId,
            dinnerId,
            DateTime.UtcNow,
            DateTime.UtcNow);
    }
}