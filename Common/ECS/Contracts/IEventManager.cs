using Common.ECS.Components;
using Common.ECS.SystemEvents;
using System;

namespace Common.ECS.Contracts
{
    public interface IEventManager
    {
        event EventHandler<InputEventArgs> InputEvent;
        void RaiseInputEvent(PlayerNumber player, byte input);

        event EventHandler<EntityAddedEventArgs> EntityAddedEvent;
        void RaiseEntityAddedEvent(Entity e);
    }
}