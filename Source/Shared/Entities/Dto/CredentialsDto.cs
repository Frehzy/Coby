using System;

namespace Shared.Entities.Dto;

public class CredentialsDto
{
    public Guid WaiterId { get; }

    public CredentialsDto(Guid waiterId) =>
        WaiterId = waiterId;
}