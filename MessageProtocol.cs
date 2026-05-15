using System;

namespace MidiApp.Common
{
    [Serializable]
    public enum MessageType : byte
    {
        Initialize = 0,
        ConfigureClient = 1,
        SpotUpdate = 2,
        Message = 3
    }

    [Serializable]
    public struct ClientMessage
    {
        public int clientID;
        public string message;
        public int[] spots;
        public int[] zooms;
        public double[] HeightOffsets;
        public int timeout;
    }
    public static class Protocol
    {
        public const int ProtocolVersion = 1;
    }
}
