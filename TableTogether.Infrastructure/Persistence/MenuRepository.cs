using TableTogether.Application.Common.Interfaces.Persistence;
using TableTogether.Domain.Menu;

namespace TableTogether.Infrastructure.Persistence;

public class MenuRepository : IMenuRepository
{

    private static readonly List<Menu> _menus = new();
    public void Add(Menu menu)
    {
        _menus.Add(menu);
    }
}