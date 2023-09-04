namespace ModelLibrary.Util;

internal static class Util
{
    internal static byte Valid(byte maxValue, byte value)
    {
        if (value < 1 || value > maxValue)
            throw new System.ArgumentOutOfRangeException();
        else
            return value;
    }
}