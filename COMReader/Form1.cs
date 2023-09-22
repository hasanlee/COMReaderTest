using System.IO.Ports;
using System.Text.RegularExpressions;

namespace COMReader
{
    public partial class Form1 : Form
    {
        private bool stop = false;
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
            var regex = new Regex(txtRegexTemplate.Text);
            string data = SerialPortClient.serialPort.ReadExisting();
            txtData.Invoke(new Action(() =>
            {
                if (chkUseRegex.Checked)
                {
                    txtData.Text += regex.Match(data).Groups[1].Value + "\n";
                }
                else
                {
                    txtData.Text += data + "\n";
                }
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

        private void txtData_TextChanged(object sender, EventArgs e)
        {
            txtData.ScrollToBottom();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string msg = txtMessage.Text;
            SerialPortClient.Send(msg);
            txtSentData.Text += msg + "\n";
        }

        private async void btnTestData_Click(object sender, EventArgs e)
        {
            btnTestData.Text = "Sending...";
            int count = (int)nmCount.Value;
            string template = txtTemplate.Text;
            int sleep = (int)nmSleep.Value;
            string msg = "";
            var task = Task.Run(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    if (stop)
                    {
                        stop = false;
                        break;
                    }
                    string randomNumber = new Random().Next(0, 90000).ToString();
                    if (chkAddAfter.Checked)
                    {
                        msg = template.Replace("{number}", randomNumber);
                    }
                    else
                    {
                        msg = randomNumber;
                    }
                    SerialPortClient.Send(msg);
                    txtSentData.Invoke(new Action(() =>
                    {
                        txtSentData.Text += msg + "\n";
                    }));
                    Thread.Sleep(sleep);
                }
            });
            await task;

            if (task.Status == TaskStatus.RanToCompletion)
            {
                btnTestData.Text = "Send Test Data";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stop = true;
        }

        private void txtSentData_TextChanged(object sender, EventArgs e)
        {
            txtSentData.ScrollToBottom();
        }

        private void btnClearSent_Click(object sender, EventArgs e)
        {
            txtSentData.Clear();
        }

        private void btnClearReceived_Click(object sender, EventArgs e)
        {
            txtData.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerialPortClient.Close();
        }
    }
}