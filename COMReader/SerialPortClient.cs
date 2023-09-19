using System.Diagnostics;
using System.IO.Ports;

namespace COMReader
{
    public class SerialPortClient
    {
        public static SerialPort serialPort;
        public static string[] GetPortNames()
        {
            return SerialPort.GetPortNames();
        }

        public static void Open(string port,int baudRate,Parity parity,int dataBits,StopBits stopBits)
        {
            serialPort = new SerialPort(port, baudRate, parity, dataBits, stopBits);
            try
            {
                serialPort.Open();
                Debug.WriteLine("Serial port opened.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex.Message);
                return;
            }
        }

        public static void Close()
        {
            if (serialPort is not null)
            {
                serialPort.Close();
            }
        }
    }
}
