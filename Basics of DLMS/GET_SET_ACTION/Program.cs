namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DlmsService.MeterObject[] meterObjects = new DlmsService.MeterObject[]
        {
            new DlmsService.MeterObject { OBIS = new byte[] { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06 }, Name = "Voltage Meter", Value = 220 },
            new DlmsService.MeterObject { OBIS = new byte[] { 0x01, 0x02, 0x03, 0x04, 0x05, 0x07 }, Name = "Energy Meter", Value = 150 },
        };

            DlmsService dlmsService = new DlmsService(meterObjects);

            // Example OBIS codes for testing
            byte[] obis_voltage = new byte[] { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06 };
            byte[] obis_energy = new byte[] { 0x01, 0x02, 0x03, 0x04, 0x05, 0x07 };

            // SET Service Example
            dlmsService.DlmsSet(obis_voltage, 240);  // Set the voltage meter value to 240

            // ACTION Service Example
            dlmsService.DlmsAction(obis_energy, "RESET");  // Reset the energy meter values

            dlmsService.DlmsGet(obis_voltage);
            byte[] obis_energy_temp = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x08 };
            dlmsService.DlmsGet(obis_energy_temp);
        }
    }
}
