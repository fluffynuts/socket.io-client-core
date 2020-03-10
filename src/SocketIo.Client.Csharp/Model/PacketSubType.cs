﻿namespace Socket.Io.Csharp.Core.Model
{
    /// <summary>
    /// Socket-io type
    /// </summary>
    public enum PacketSubType
    {
        Connect = 0,
        Disconnect = 1,
        Event = 2,
        Ack = 3,
        Error = 4,
        BinaryEvent = 5,
        BinaryAck = 6
    }
}