using CleanTeeth.Domain.Entities;
using CleanTeeth.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples.Application.Interfaces;

public interface INotificationService
{
    void Send(Patient patient, string message);
}
