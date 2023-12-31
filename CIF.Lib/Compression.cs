﻿namespace CIF.Lib
{
    public static class Compression
    {
        public static byte[] Compress(byte[] data)
        {
            List<byte> compressed = new();
            byte lastValue = data[0];
            byte count = 1;

            for (int i = 1; i < data.Length; i++)
            {
                if (data[i] == lastValue)
                {
                    try
                    {
                        checked
                        {
                            count++;
                        }
                    }
                    catch
                    {
                        compressed.Add(count);
                        compressed.Add(lastValue);
                        count = 1;
                    }
                }
                else
                {
                    compressed.Add(count);
                    compressed.Add(lastValue);
                    count = 1;
                }

                lastValue = data[i];
            }

            compressed.Add(count);
            compressed.Add(lastValue);

            return compressed.ToArray();
        }

        public static byte[] Decompress(byte[] data)
        {
            List<byte> decompressed = new();

            for (int i = 0; i < data.Length; i += 2)
            {
                byte count = data[i];
                byte value = data[i + 1];

                for (int j = 0; j < count; j++)
                {
                    decompressed.Add(value);
                }
            }

            return decompressed.ToArray();
        }
        public static int RoundOff(this int i, int nearest)
        {
            return ((int)Math.Round(i / (float)nearest)) * nearest;
        }
    }
}
