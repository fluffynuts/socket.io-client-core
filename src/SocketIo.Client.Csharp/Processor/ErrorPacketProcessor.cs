﻿using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Socket.Io.Csharp.Core.Extensions;
using Socket.Io.Csharp.Core.EventArguments;
using Socket.Io.Csharp.Core.Model;

namespace Socket.Io.Csharp.Core.Processor
{
    internal class ErrorPacketProcessor : IPacketProcessor
    {
        private readonly IEventEmitter _emitter;
        private readonly ILogger _logger;

        internal ErrorPacketProcessor(IEventEmitter emitter, ILogger logger)
        {
            _emitter = emitter;
            _logger = logger;
        }
        
        public ValueTask ProcessAsync(Packet packet)
        {
            _logger.LogError($"Received error packet. Data: {packet.Data}");
            _emitter.EmitAsync(SocketIoEvent.Error, new ErrorEventArgs(packet.Data));
            return default;
        }
    }
}