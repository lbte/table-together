using TableTogether.Domain.Menu;

namespace TableTogether.Application.Common.Interfaces.Persistence;

public interface IMenuRepository
{
    void Add(Menu menu);
}