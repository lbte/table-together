using ErrorOr;

using MediatR;

using TableTogether.Application.Common.Interfaces.Persistence;
using TableTogether.Domain.Host.ValueObjects;
using TableTogether.Domain.Menu;
using TableTogether.Domain.Menu.Entities;

namespace TableTogether.Application.Menus.Commands.CreateMenu;

public class CreateMenuCommandHandler : IRequestHandler<CreateMenuCommand, ErrorOr<Menu>>
{
    private readonly IMenuRepository _menuRepository;

    public CreateMenuCommandHandler(IMenuRepository menuRepository)
    {
        _menuRepository = menuRepository;
    }

    public async Task<ErrorOr<Menu>> Handle(CreateMenuCommand request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask; // temporary solution to make the convertion work

        var menu = Menu.Create(
            request.Name,
            request.Description,
            request.Sections.ConvertAll(section => MenuSection.Create(
                section.Name,
                section.Description,
                section.Items.ConvertAll(item => MenuItem.Create(
                    item.Name,
                    item.Description
                ))
            )),
            HostId.Create(request.HostId));

        _menuRepository.Add(menu);

        return menu;
    }
}
