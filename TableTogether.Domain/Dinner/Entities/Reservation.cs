using TableTogether.Domain.Bill.ValueObjects;
using TableTogether.Domain.Common.Models;
using TableTogether.Domain.Dinner.ValueObjects;
using TableTogether.Domain.Guest.ValueObjects;

namespace TableTogether.Domain.Dinner.Entities;

public sealed class Reservation : Entity<ReservationId>
{
    private Reservation(
        ReservationId id,
        int guestCount,
        ReservationStatus status,
        GuestId guestId,
        BillId billId,
        DateTime arrivalDateTime,
        DateTime createdDateTime,
        DateTime updatedDateTime) : base(id)
    {
        GuestCount = guestCount;
        Status = status;
        GuestId = guestId;
        BillId = billId;
        ArrivalDateTime = arrivalDateTime;
        CreatedDateTime = createdDateTime;
        UpdatedDateTime = updatedDateTime;
    }

    public int GuestCount { get; }
    public ReservationStatus Status { get; }
    public GuestId GuestId { get; }
    public BillId BillId { get; }
    public DateTime ArrivalDateTime { get; }
    public DateTime CreatedDateTime { get; }
    public DateTime UpdatedDateTime { get; }

    public static Reservation Create(
        int guestCount,
        ReservationStatus status,
        GuestId guestId,
        BillId billId,
        DateTime arrivalDateTime)
    {
        return new(
            ReservationId.CreateUnique(),
            guestCount,
            status,
            guestId,
            billId,
            arrivalDateTime,
            DateTime.UtcNow,
            DateTime.UtcNow);
    }

}