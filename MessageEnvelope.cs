using System;

namespace MidiApp.Common
{
    public class MessageEnvelope
    {
        public int Version { get; set; } = Protocol.ProtocolVersion;
        public MessageType Type { get; set; }
        public object Payload { get; set; }
    }
}
