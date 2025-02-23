using TableTogether.Domain.Common.Models;
using TableTogether.Domain.Common.ValueObjects;
using TableTogether.Domain.Dinner.ValueObjects;
using TableTogether.Domain.Host.ValueObjects;
using TableTogether.Domain.Menu.Entities;
using TableTogether.Domain.Menu.ValueObjects;
using TableTogether.Domain.MenuReview.ValueObjects;

namespace TableTogether.Domain.Menu;

public sealed class Menu : AggregateRoot<MenuId>
{
    private readonly List<MenuSection> _sections = new();
    private readonly List<DinnerId> _dinnerIds = new();
    private readonly List<MenuReviewId> _menuReviewIds = new();
    public string Name { get; }
    public string Description { get; }
    public AverageRating AverageRating { get; }
    public IReadOnlyList<MenuSection> Sections => _sections.AsReadOnly();
    public HostId HostId { get; }
    public IReadOnlyList<DinnerId> DinnerIds => _dinnerIds.AsReadOnly();
    public IReadOnlyList<MenuReviewId> MenuReviewIds => _menuReviewIds.AsReadOnly();
    public DateTime CreatedDateTime { get; }
    public DateTime UpdatedDateTime { get; }

    private Menu(
        MenuId id,
        string name,
        string description,
        AverageRating averageRating,
        HostId hostId,
        DateTime createdDateTime,
        DateTime updatedDateTime) : base(id)
    {
        Name = name;
        Description = description;
        AverageRating = averageRating;
        HostId = hostId;
        CreatedDateTime = createdDateTime;
        UpdatedDateTime = updatedDateTime;
    }

    public static Menu Create(
        string name,
        string description,
        AverageRating averageRating,
        HostId hostId)
    {
        return new(
            MenuId.CreateUnique(),
            name,
            description,
            averageRating,
            hostId,
            DateTime.UtcNow,
            DateTime.UtcNow);
    }
}