using System;

namespace Shared.IniManager;

public class Settings
{
    public Guid OrganizationId { get; private set; }

    public Settings() { }

    public Settings(Guid orgazitanionId)
    {
        OrganizationId = orgazitanionId;
    }
}
