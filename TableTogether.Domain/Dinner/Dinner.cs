using TableTogether.Domain.Common.Models;
using TableTogether.Domain.Dinner.Entities;
using TableTogether.Domain.Dinner.ValueObjects;
using TableTogether.Domain.Host.ValueObjects;
using TableTogether.Domain.Menu.ValueObjects;

namespace TableTogether.Domain.Dinner;

public sealed class Dinner : AggregateRoot<DinnerId>
{
    private readonly List<Reservation> _reservations = new();
    public string Name { get; }
    public string Description { get; }
    public DateTime StartedDateTime { get; }
    public DateTime EndedDateTime { get; }
    public DinnerStatus Status { get; }
    public bool IsPublic { get; }
    public int MaxGuests { get; }
    public Price Price { get; }
    public HostId HostId { get; }
    public MenuId MenuId { get; }
    public string ImageUrl { get; }
    public Location Location { get; }
    public IReadOnlyList<Reservation> Reservations => _reservations.AsReadOnly();
    public DateTime CreatedDateTime { get; }
    public DateTime UpdatedDateTime { get; }
    
    private Dinner(
        DinnerId id,
        string name,
        string description,
        DateTime startedDateTime,
        DateTime endedDateTime,
        DinnerStatus status,
        bool isPublic,
        int maxGuests,
        Price price,
        HostId hostId,
        MenuId menuId,
        string imageUrl,
        Location location,
        DateTime createdDateTime,
        DateTime updatedDateTime) : base(id)
    {
        Name = name;
        Description = description;
        StartedDateTime = startedDateTime;
        EndedDateTime =  endedDateTime;
        Status =  status;
        IsPublic = isPublic;
        MaxGuests = maxGuests;
        Price = price;
        HostId = hostId;
        MenuId = menuId;
        ImageUrl = imageUrl;
        Location = location;
        CreatedDateTime = createdDateTime;
        UpdatedDateTime = updatedDateTime;
    }

    public static Dinner Create(
        string name,
        string description,
        DateTime startedDateTime,
        DateTime endedDateTime,
        DinnerStatus status,
        bool isPublic,
        int maxGuests,
        Price price,
        HostId hostId,
        MenuId menuId,
        string imageUrl,
        Location location
    )
    {
        return new(
            DinnerId.CreateUnique(),
            name,
            description,
            startedDateTime,
            endedDateTime,
            status,
            isPublic,
            maxGuests,
            price,
            hostId,
            menuId,
            imageUrl,
            location,
            DateTime.UtcNow,
            DateTime.UtcNow
        );
    }
}