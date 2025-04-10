using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SmartCardService
{
    public static class APDU
    {
        public static byte[] MSE_SET_APDU()
        {
            return new byte[] { 0x00, 0x22, 0x41, 0xB6, 0x05, 0x04, 0x80, 0x01, 0x84, 0x83 };
        }

        public static byte[] VERIFY_APDU(string pin)
        {
            var bcdEncodedPin = EncodeBcd(pin);
            List<byte> apdu = new List<byte> { 0x00, 0x20, 0x00, 0x01, 0x08, 0x24 };
            apdu.AddRange(bcdEncodedPin);
            apdu.AddRange(new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff });
            return apdu.ToArray();
        }

        public static byte[] PSO_APDU(string dataToSign)
        {
            byte[] hashed = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(dataToSign));
            byte[] digestInfoPrefix = new byte[]
            {
                // 0x30, 0x31, 0x0D, 0x06, 0x09, 0x60, 0x86, 0x48, 0x01, 0x65, 0x03, 0x04, 0x02, 0x01, 0x05, 0x00, 0x04, 0x20
                0x30 ,0x31 ,0x30 ,0x0d ,0x06 ,0x09 ,0x60 ,0x86 ,0x48 ,0x01 ,0x65 ,0x03 ,0x04 ,0x02 ,0x01 ,0x05 ,0x00 ,0x04 ,0x20
            };
            List<byte> digestInfo = new List<byte>(digestInfoPrefix);
            digestInfo.AddRange(hashed);
            List<byte> psoApdu = new List<byte> { 0x00, 0x2A, 0x9E, 0x9A, (byte)(digestInfo.Count) };
            psoApdu.AddRange(digestInfo);
            return psoApdu.ToArray();
        }

        public static byte[] GET_RESPONSE_APDU()
        {
            return new byte[] { 0x00, 0xC0, 0x00, 0x00, 0x00 };
        }

        public static byte[] LOG_OFF()
        {
            return new byte[] { 0x80, 0xe6, 0x00, 0x00, 0x00 };
        }

        private static byte[] EncodeBcd(string pin)
        {
            if (pin.Length % 2 != 0)
                pin = "0" + pin;
            List<byte> encoded = new List<byte>();
            for (int i = 0; i < pin.Length; i += 2)
            {
                encoded.Add((byte)((pin[i] - '0') << 4 | (pin[i + 1] - '0')));
            }
            return encoded.ToArray();
        }
    }
}
