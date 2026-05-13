using System;

namespace MidiApp.Common
{
    [Serializable]
    public class FixtureTypeDefinition
    {
        public string Name { get; set; }
        public double PanRange { get; set; }
        public double TiltRange { get; set; }
        public bool PanInvert { get; set; }
        public bool TiltInvert { get; set; }
        public int PanDMXBase { get; set; }
        public int TiltDMXBase { get; set; }
        public int ZoomDMXBase { get; set; }
        public int IrisDMXBase { get; set; }
        public double ZoomMin { get; set; }
        public double ZoomMax { get; set; }
        public double IrisMin { get; set; }
        public double IrisMax { get; set; }
        public double PanOffset { get; set; }

        public override string ToString()
        {
            return !string.IsNullOrEmpty(Name) ? Name : base.ToString();
        }
    }
}
