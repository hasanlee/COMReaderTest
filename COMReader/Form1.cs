using System.IO.Ports;

namespace COMReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPorts.DataSource = SerialPortClient.GetPortNames();
            int[] baudrates = new int[] { 110, 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 57600, 115200, 128000, 256000 };
            cmbBaudrate.DataSource = baudrates;
            cmbParity.DataSource = Enum.GetValues(typeof(Parity));
            cmbStopbits.DataSource = Enum.GetValues(typeof(StopBits));

            cmbPorts.SelectedItem = "COM29";
            cmbBaudrate.SelectedItem = 9600;
            cmbParity.SelectedItem = Parity.None;
            cmbStopbits.SelectedItem = StopBits.One;
            nmDataBit.Value = 8;

            CheckStatus();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string port = (string)cmbPorts.SelectedValue;
            int baudRate = (int)cmbBaudrate.SelectedValue;
            Parity parity = (Parity)cmbParity.SelectedItem;
            int dataBits = (int)nmDataBit.Value;
            StopBits stopBits = (StopBits)cmbStopbits.SelectedItem;

            SerialPortClient.Open(port, baudRate, parity, dataBits, stopBits);
            SerialPortClient.serialPort.DataReceived += dataReceived;

            CheckStatus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SerialPortClient.Close();
            CheckStatus();
        }

        private void dataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = SerialPortClient.serialPort.ReadExisting();
            txtData.Invoke(new Action(() =>
            {
                txtData.Text += data;
            }));
        }
        private void CheckStatus()
        {
            if (SerialPortClient.serialPort is not null)
            {
                if (SerialPortClient.serialPort.IsOpen)
                {
                    lblStatus.Text = "Connected";
                    lblStatus.BackColor = Color.Green;
                    lblStatus.ForeColor = Color.Black;
                }
                else
                {
                    lblStatus.Text = "Disconnected";
                    lblStatus.BackColor = Color.Red;
                    lblStatus.ForeColor = Color.White;
                }
            }
            else
            {
                lblStatus.Text = "Disconnected";
                lblStatus.BackColor = Color.Red;
                lblStatus.ForeColor = Color.White;
            }

        }
    }
}