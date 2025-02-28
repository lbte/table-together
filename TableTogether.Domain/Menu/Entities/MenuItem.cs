using TableTogether.Domain.Common.Models;
using TableTogether.Domain.Menu.ValueObjects;

namespace TableTogether.Domain.Menu.Entities;

public sealed class MenuItem : Entity<MenuItemId>
{
    private MenuItem(MenuItemId id, string name, string description) : base(id)
    {
        Name = name;
        Description = description;
    }

    public string Name { get; }
    public string Description { get; }

    public static MenuItem Create(
        string name,
        string description)
    {
        return new(
            MenuItemId.CreateUnique(),
            name,
            description);
    }
}