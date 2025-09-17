
// GET Request APDU builder
public class GetRequestApdu
{
    public static byte[] CreateGetRequest(ObisCode obis, ushort classId, byte attributeId)
    {
        List<byte> apdu = new List<byte>();

        // GET-Request tag
        apdu.Add(0xC0); // GET-Request
        apdu.Add(0x01); // Get-Request-Normal
                        // Invoke ID and Priority
        apdu.Add(0x01); // Example: Invoke ID = 1, normal priority

        // Class ID (2 bytes)
        apdu.Add((byte)(classId >> 8)); // High byte
        apdu.Add((byte)(classId & 0xFF)); // Low byte

        // OBIS code
        apdu.AddRange(obis.ToByteArray());

        // Attribute ID
        apdu.Add(attributeId);

        // Access Selector (0 = no selective access)
        apdu.Add(0x00);

        return apdu.ToArray();
    }
}