using System;

namespace Shared.Dto.Enities;

public record CredentialsDto
{
    public Guid WaiterId { get; init; }

    public CredentialsDto() { }

    public CredentialsDto(Guid waiterId) =>
        WaiterId = waiterId;
}