using System;

namespace MidiApp.Common
{
    [Serializable]
    public class Marker
    {
        // simple serializable 3D point to avoid WPF dependencies
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public int clientID { get; set; }
        public int markerID { get; set; }

        public override string ToString() => $"({X},{Y},{Z})";
    }
}
