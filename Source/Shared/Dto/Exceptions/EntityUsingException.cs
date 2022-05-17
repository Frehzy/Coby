using System;
using System.Runtime.Serialization;

namespace Shared.Dto.Exceptions;

[Serializable]
public class EntityUsingException : ApiException
{
    public Guid EntityId { get; }

    public Type EntityType { get; }

    protected EntityUsingException() { }

    public EntityUsingException(SerializationInfo info, StreamingContext context) : base(info, context) { }

    public EntityUsingException(Guid entityId, Type entityType)
    {
        EntityId = entityId;
        EntityType = entityType;
    }

    public EntityUsingException(Guid entityId, Type entityType, string message, Exception ex) : base(message, ex)
    {
        EntityId = entityId;
        EntityType = entityType;
    }
}