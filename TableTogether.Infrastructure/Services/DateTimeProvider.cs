using TableTogether.Application.Common.Interfaces.Services;

namespace TableTogether.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}