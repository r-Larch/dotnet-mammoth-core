namespace Mammoth.Couscous.java.lang;

internal partial class Character {
    public static bool isBmpCodePoint(int var0)
    {
        return var0 >>> 16 == 0;
    }

    internal static char highSurrogate(int codePoint)
    {
        return (char) ((codePoint >>> 10) + '\ud7c0');
    }

    internal static char lowSurrogate(int codePoint)
    {
        return (char) ((codePoint & 1023) + '\udc00');
    }
}
