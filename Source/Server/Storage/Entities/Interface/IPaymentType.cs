using System;

namespace Storage.Entities.Interface;

public interface IPaymentType
{
    public Guid Id { get; }

    public string Name { get; }
}