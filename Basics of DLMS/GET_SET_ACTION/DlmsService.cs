using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DlmsService
    {
        public class MeterObject
        {
            public byte[] OBIS { get; set; }
            public string Name { get; set; }
            public int Value { get; set; }
        }

        private MeterObject[] meterObjects;
        private int meterObjectCount;

        public DlmsService(MeterObject[] objects)
        {
            meterObjects = objects;
            meterObjectCount = objects.Length;
        }

        // Helper function to match OBIS codes
        private bool ObisMatch(byte[] obis1, byte[] obis2)
        {
            for (int i = 0; i < 6; i++)
            {
                if (obis1[i] != obis2[i])
                    return false;
            }
            return true;
        }

        // GET Service
        public void DlmsGet(byte[] obis)
        {
            for (int i = 0; i < meterObjectCount; i++)
            {
                if (ObisMatch(obis, meterObjects[i].OBIS))
                {
                    Console.WriteLine($"[GET] {meterObjects[i].Name} = {meterObjects[i].Value}");
                    return;
                }
            }
            Console.WriteLine("[GET] OBIS not found.");
        }

        // SET Service
        public void DlmsSet(byte[] obis, int newValue)
        {
            for (int i = 0; i < meterObjectCount; i++)
            {
                if (ObisMatch(obis, meterObjects[i].OBIS))
                {
                    meterObjects[i].Value = newValue;
                    Console.WriteLine($"[SET] {meterObjects[i].Name} updated to {newValue}");
                    return;
                }
            }
            Console.WriteLine("[SET] OBIS not found.");
        }

        // ACTION Service
        public void DlmsAction(byte[] obis, string method)
        {
            if (method.Equals("RESET", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("[ACTION] Resetting meter values...");
                for (int i = 0; i < meterObjectCount; i++)
                {
                    meterObjects[i].Value = 0;
                }
                Console.WriteLine("[ACTION] Reset complete.");
            }
            else if (method.Equals("SYNC_TIME", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("[ACTION] Synchronizing meter clock to system time...");
                // Time sync logic here (e.g., update clock based on system time)
                Console.WriteLine("[ACTION] Synchronization complete.");
            }
            else
            {
                Console.WriteLine("[ACTION] Unknown method.");
            }
        }
    }
}