using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace udpPacketReceiver
{
    public partial class Form1 : Form
    {
        private int xplaneDataSendPort = 49001;
        //private String commandID = "";
        private byte commandID = 0;

        private int receiveCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            receivePortBox.Text = xplaneDataSendPort.ToString();
                //theIP = x.ToString();
        }

        private void startStopListenButton_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
                startStopListenButton.Text = "Start";
                return;
            }
            if(String.IsNullOrEmpty(receivePortBox.Text))
            {
                receivePortBox.Focus();
                return;
            }

            if (String.IsNullOrEmpty(commandIDBox.Text))
            {
                commandIDBox.Focus();
                return;
            }

            xplaneDataSendPort = int.Parse(receivePortBox.Text);
            //commandID = commandIDBox.Text;
            commandID = byte.Parse(commandIDBox.Text);

            backgroundWorker1.RunWorkerAsync();

            startStopListenButton.Text = "Stop";

        }

        private void backgroundWorker1_DoWork(object sen, DoWorkEventArgs e)
        {
            byte[] data = new byte[41];
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, xplaneDataSendPort);

            UdpClient newsock = new UdpClient(ipep);

            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);

            String message = "";

            while (true)
            {
                if (backgroundWorker1.CancellationPending == true)
                {
                    e.Cancel = true;
                    newsock.Close();
                    return;
                }

                data = newsock.Receive(ref sender);

                byte[] commandMessage = new byte[36];

                for (int i = 5; i < data.Length; i = i + 36)
                {

                    Array.Copy(data, i, commandMessage, 0, 36);
                    if (commandMessage[0] == commandID)
                    {

                        

                        for (int index = 0; index < commandMessage.Length; index++)
                        {
                            message += " " + commandMessage[index];
                        }

                        //message += "\r\n";

                        addToTextBox(message);

                        message = "";
                    }
                }

                
            }
        }

        private void addToTextBox(String message)
        {
            Invoke((MethodInvoker)(() =>
            {
                //messageBox.Text += message;
                listBox1.Items.Add(message);
                receiveCountChanger();
            }));
        }

        private void saveMessagesButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text File|*.txt";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName.Length < 2)
            {
                return;
            }

            TextWriter tw = new StreamWriter(saveFileDialog1.FileName);

            foreach (String line in listBox1.Items)
            {
                tw.WriteLine(line);
            }

            //tw.Write(messageBox.Text);

            tw.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //messageBox.Text = "";
            receiveCount = -1;
            receiveCountChanger();
        }

        private void receiveCountChanger()
        {
            //receiveCount++;
            label3.Text = "Received : ";
            label3.Text += ++receiveCount;
        }
    }
}
