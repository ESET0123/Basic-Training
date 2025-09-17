public class ObisCode
{
    public byte A { get; set; }
    public byte B { get; set; }
    public byte C { get; set; }
    public byte D { get; set; }
    public byte E { get; set; }
    public byte F { get; set; }

    public ObisCode(byte a, byte b, byte c, byte d, byte e, byte f)
    {
        A = a; B = b; C = c; D = d; E = e; F = f;
    }

    public byte[] ToByteArray()
    {
        return new byte[] { A, B, C, D, E, F };
    }

    public override string ToString()
    {
        return $"{A}-{B}:{C}.{D}.{E}.{F}";
    }
}
