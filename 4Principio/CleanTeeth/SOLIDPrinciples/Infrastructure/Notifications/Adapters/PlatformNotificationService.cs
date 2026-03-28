using CleanTeeth.Domain.Entities;
using SOLIDPrinciples.Application.Interfaces;
using SOLIDPrinciples.Infrastructure.Notifications.Platforms;
using System;

namespace SOLIDPrinciples.Infrastructure.Notifications.Adapters;

public class PlatformNotificationService : INotificationService
{
    private readonly IPlatformService _platformService;

    public PlatformNotificationService(IPlatformService platformService)
    {
        _platformService = platformService;
    }

    public void Send(Patient patient, string message)
    {
        _platformService.Send(patient);
    }
}
