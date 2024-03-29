﻿using NerdStore.Core.DomainObjects;
using NerdStore.Core.Messages;

namespace NerdStore.Core.Bus
{
    public interface IMediatorHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;

        Task PublicarDomainEvent<T>(T notificacao) where T : DomainEvent;
    }
}