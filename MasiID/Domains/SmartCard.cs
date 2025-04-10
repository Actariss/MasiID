using PCSC.Exceptions;
using PCSC.Utils;
using PCSC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCardService
{
    public class SmartCard
    {
        private SCardContext _context;
        private SCardReader _reader;
        private nint _pioSendPci;

        public SmartCard()
        {
            _context = new SCardContext();
            _reader = new SCardReader(_context);
        }

        public void Connect()
        {
            _context.Establish(SCardScope.System);
            string[] readers = _context.GetReaders();
            if (readers.Length <= 0)
                throw new PCSCException(SCardError.NoReadersAvailable, "No smartcard reader found.");

            SCardError err = _reader.Connect(readers[0], SCardShareMode.Shared, SCardProtocol.T0 | SCardProtocol.T1);
            CheckErr(err);

            _pioSendPci = _reader.ActiveProtocol switch
            {
                SCardProtocol.T0 => SCardPCI.T0,
                SCardProtocol.T1 => SCardPCI.T1,
                _ => throw new PCSCException(SCardError.ProtocolMismatch, "Unsupported protocol.")
            };
        }

        public bool MseSet()
        {
            byte[] cmd = APDU.MSE_SET_APDU();
            byte[] response = TransmitCommand(cmd);

            byte sw1 = response[response.Length - 2];
            byte sw2 = response[response.Length - 1];


            if (sw1 == 0x90 && sw2 == 0x00)
            {
                Console.WriteLine($"[V] Command 'MSE_SET' success : {BitConverter.ToString(response)}");
                return true;
            }
            else
            {
                Console.WriteLine($"[X] Command 'MSE_SET' failure : {BitConverter.ToString(response)}");
                return false;
            }
        }

        public bool VerifyPin(string pin)
        {
            byte[] cmd = APDU.VERIFY_APDU(pin);
            byte[] response = TransmitCommand(cmd);

            byte sw1 = response[response.Length - 2];
            byte sw2 = response[response.Length - 1];


            if (sw1 == 0x90 && sw2 == 0x00)
            {
                Console.WriteLine($"[V] Command 'VERIFY' success : {BitConverter.ToString(response)}");
                return true;
            }
            else
            {
                Console.WriteLine($"[X] Command 'VERIFY' failure : {BitConverter.ToString(response)}");
                return false;
            }
        }

        public bool SignData(string dataToSign)
        {
            byte[] cmd = APDU.PSO_APDU(dataToSign);
            byte[] response = TransmitCommand(cmd);

            byte sw1 = response[response.Length - 2];
            byte sw2 = response[response.Length - 1];


            if (sw1 == 0x61 && sw2 == 0x00)
            {
                Console.WriteLine($"[V] Command 'SIGN' success : {BitConverter.ToString(response)}");
                return true;
            }
            else
            {
                Console.WriteLine($"[X] Command 'SIGN' failure : {BitConverter.ToString(response)}");
                return false;
            }
        }

        public byte[] GetResponse()
        {
            byte[] cmd = APDU.GET_RESPONSE_APDU();
            byte[] response = TransmitCommand(cmd, 258);

            byte sw1 = response[response.Length - 2];
            byte sw2 = response[response.Length - 1];

            if (sw1 == 0x90 && sw2 == 0x00)
            {
                Console.WriteLine($"[V] Command 'GET_RESPONSE' success : {BitConverter.ToString(response)}");
                return response.Take(response.Length - 2).ToArray();
            } else
            {
                Console.WriteLine($"[X] Command 'GET_RESPONSE' failure : {BitConverter.ToString(response)}");
                return null;
            }
        }

        public bool LogOff()
        {
            byte[] cmd = APDU.LOG_OFF();
            byte[] response = TransmitCommand(cmd);

            byte sw1 = response[response.Length - 2];
            byte sw2 = response[response.Length - 1];


            if (sw1 == 0x90 && sw2 == 0x00)
            {
                Console.WriteLine($"[V] Command 'LOG_OFF' success : {BitConverter.ToString(response)}");
                return true;
            }
            else
            {
                Console.WriteLine($"[X] Command 'LOG_OFF' failure : {BitConverter.ToString(response)}");
                return false;
            }
        }

        private byte[] TransmitCommand(byte[] cmd, int responseSize = 256)
        {
            byte[] recvBuffer = new byte[responseSize];
            SCardError err = _reader.Transmit(_pioSendPci, cmd, ref recvBuffer);
            CheckErr(err);
            return recvBuffer;
        }


        private static void CheckErr(SCardError err)
        {
            if (err != SCardError.Success)
                throw new PCSCException(err, SCardHelper.StringifyError(err));
        }
    }
}
