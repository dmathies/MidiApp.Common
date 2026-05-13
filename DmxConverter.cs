using System;

namespace MidiApp.Common
{
    public static class DmxConverter
    {
        public static int To16Bit(int msb, int lsb) => (msb << 8) | (lsb & 0xFF);

        public static (int msb, int lsb) From16Bit(int value) => ((value >> 8) & 0xFF, value & 0xFF);

        public static double DmxToAngle(int value16, double range)
        {
            return (value16 / 65535.0) * range - (range / 2.0);
        }

        public static int AngleToDmx(double angle, double range)
        {
            double normalized = (angle + (range/2.0)) / range;
            return (int)Math.Round(normalized * 65535.0);
        }
    }
}
