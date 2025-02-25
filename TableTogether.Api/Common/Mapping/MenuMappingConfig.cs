using Mapster;

using TableTogether.Application.Menus.Commands.CreateMenu;
using TableTogether.Contracts.Menus;
using TableTogether.Domain.Menu;
using MenuSection = TableTogether.Domain.Menu.Entities.MenuSection;
using MenuItem = TableTogether.Domain.Menu.Entities.MenuItem;

namespace TableTogether.Api.Common.Mapping;

public class MenuMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<(CreateMenuRequest Request, string HostId), CreateMenuCommand>()
        .Map(dest => dest.HostId, src => src.HostId) // the hostId from the request maps to the HostId in the command
        .Map(dest => dest, src => src.Request); // in the dest all the rest of the properties, take them from the request

        config.NewConfig<Menu, MenuResponse>()
        .Map(dest => dest.Id, src => src.Id.Value)
        .Map(dest => dest.AverageRating, src => src.AverageRating.NumRatings > 0 ? src.AverageRating.Value : (double?)null)
        .Map(dest => dest.HostId, src => src.HostId.Value)
        .Map(dest => dest.DinnerIds, src => src.DinnerIds.Select(id => id.Value))
        .Map(dest => dest.MenuReviewIds, src => src.MenuReviewIds.Select(id => id.Value));

        config.NewConfig<MenuSection, MenuSectionResponse>()
        .Map(dest => dest.Id, src => src.Id.Value);

        config.NewConfig<MenuItem, MenuItemResponse>()
        .Map(dest => dest.Id, src => src.Id.Value); 
    }
}