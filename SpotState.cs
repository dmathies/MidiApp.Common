using System;

namespace MidiApp.Common
{
    [Serializable]
    public class SpotState
    {
        public double Pan { get; set; }
        public double Tilt { get; set; }
        public int Zoom { get; set; }
        public double HeightOffset { get; set; }
        public double TargetX { get; set; }
        public double TargetY { get; set; }
        public double TargetZ { get; set; }
        public int MouseControlID { get; set; }
    }
}